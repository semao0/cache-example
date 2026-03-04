import http from 'k6/http';
import { check, sleep } from 'k6';

// k6 run -e MODE=nocache -e VUS=50 test.js
// k6 run -e MODE=redis -e VUS=200 test.js
// k6 run -e MODE=hybrid -e VUS=500 test.js

const MODE = __ENV.MODE || 'nocache'; // nocache, redis, hybrid
const BASE_URL = 'http://localhost:5033/api/Products'; // Укажите порт вашего приложения

export const options = {
    // Настраиваем стадии (ramp-up, plateau, ramp-down)
    stages: [
        { duration: '10s', target: __ENV.VUS || 50 }, // Разгон
        { duration: '30s', target: __ENV.VUS || 50 }, // Плато (основной тест)
        { duration: '10s', target: 0 },               // Остановка
    ],
    thresholds: {
        http_req_duration: ['p(95)<1000'], // 95% запросов должны быть быстрее 1с
    },
};

export default function () {
    // Генерируем ID от 1 до 100, чтобы имитировать запросы к разным товарам (hit ratio)
    const productId = Math.floor(Math.random() * 100) + 1;
    
    const url = `${BASE_URL}/1/${MODE}`;
    
    const res = http.get(url);

    check(res, {
        'is status 200': (r) => r.status === 200,
    });

    sleep(0.1); // Небольшая пауза между запросами пользователя
}