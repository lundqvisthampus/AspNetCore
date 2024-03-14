const toggleDarkMode = () => {
    const body = document.querySelector('body');
    const darkModeEnabled = body.classList.toggle('dark-mode');
    localStorage.setItem('darkModeEnabled', darkModeEnabled);

    const logo = document.querySelector("#logotype");
    if (darkModeEnabled) {
        logo.setAttribute("src", "/images/solid.svg");
    } else {
        logo.setAttribute("src", "/images/logotype.svg");
    }
}

window.addEventListener("DOMContentLoaded", () => {
    const body = document.querySelector('body');
    const darkModeEnabled = localStorage.getItem('darkModeEnabled')

    if (darkModeEnabled === "true") {
        body.classList.add('dark-mode');
        document.getElementById("darkModeToggle").checked = true;
        document.querySelector("#logotype").setAttribute("src", "/images/solid.svg");
    }
    else {
        body.classList.remove('dark-mode');
        document.getElementById("darkModeToggle").checked = false;
        document.querySelector("#logotype").setAttribute("src", "/images/logotype.svg");
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