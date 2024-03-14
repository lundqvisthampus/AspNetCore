const toggleDarkMode = () => {
    const body = document.querySelector('body');
    const darkModeEnabled = body.classList.toggle('dark-mode');
    localStorage.setItem('darkModeEnabled', darkModeEnabled);
}

window.addEventListener("DOMContentLoaded", () => {
    const body = document.querySelector('body');
    const darkModeEnabled = localStorage.getItem('darkModeEnabled')

    if (darkModeEnabled === "true") {
        body.classList.add('dark-mode');
        document.getElementById("darkModeToggle").checked = true;
    }
    else {
        body.classList.remove('dark-mode');
        document.getElementById("darkModeToggle").checked = false;
    }
})

const toggleMenu = () => {
    document.getElementById('menu').classList.toggle('hide');
}

const checkScreenSize = () => {
    if (window.innerWidth >= 992) {
        document.getElementById('menu').classList.add('hide');
    }
}

window.addEventListener('resize', checkScreenSize);