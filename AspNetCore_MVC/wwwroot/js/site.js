const toggleMenu = () => {
    document.getElementById('menu').classList.toggle('hide');
}

const checkScreenSize = () => {
    if (window.innerWidth >= 992) {
        document.getElementById('menu').classList.add('hide');
    }
}

window.addEventListener('resize', checkScreenSize);