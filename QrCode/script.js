const inputValue = document.querySelector('#inputValue');
const btnValue = document.querySelector('#btnValue');
const imgQrCorde = document.querySelector('#imgQrCode');
const wrapper = document.querySelector('.wrapper');

let valueDefaut;

btnValue.addEventListener('click',() => {
    let qrcodeValue = inputValue.value.trim();
    if(!qrcodeValue || qrcodeValue === valueDefaut) return;
    valueDefaut = qrcodeValue;
    btnValue.innerText = 'Gerando QR Code...'
    imgQrCorde.src = `https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=${valueDefaut}`;
    imgQrCorde.addEventListener('load',() => {
        wrapper.classList.add('active');
        btnValue.innerText = 'Gerar QRCode'
    })

})