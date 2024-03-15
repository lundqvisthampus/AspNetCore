const header = document.querySelector("header")
const url = window.location.pathname

const toggleDarkMode = () => {
    const body = document.querySelector('body');
    const darkModeEnabled = body.classList.toggle('dark-mode');
    localStorage.setItem('darkModeEnabled', darkModeEnabled);

    const logo = document.querySelector("#logotype");
    const errorImg = document.querySelector("#errorImg");
    const singleCourseIcons = document.querySelectorAll("#programDetailsImg");
    

    if (darkModeEnabled) {
        logo.setAttribute("src", "/images/solid.svg");

        if (errorImg) {
            errorImg.setAttribute("src", "/images/error-404-darkmode.svg");
        }

        if (singleCourseIcons != null) {
            singleCourseIcons.forEach(icon => {
                const darkIcon = icon.getAttribute("data-darksrc")
                icon.setAttribute("src", darkIcon)
            })
        }

        if (url == "/Contact") {
            header.style.backgroundColor = "#0f121e"
        } else {
            header.style.backgroundColor = "#0B0F19";
        }
        
    } else {
        logo.setAttribute("src", "/images/logotype.svg");

        if (errorImg) {
            errorImg.setAttribute("src", "/images/error-404.svg");
        }

        if (singleCourseIcons != null) {
            singleCourseIcons.forEach(icon => {
                const lightIcon = icon.getAttribute("data-lightsrc")
                icon.setAttribute("src", lightIcon)
            })
        }

        if (url == "/Contact") {
            header.style.backgroundColor = "#F3F6FF"
        } else {
            header.style.backgroundColor = "#FFFFFF";
        }
    }
}

window.addEventListener("DOMContentLoaded", () => {
    const body = document.querySelector('body');
    const darkModeEnabled = localStorage.getItem('darkModeEnabled')

    if (darkModeEnabled === "true") {
        body.classList.add('dark-mode');
        document.getElementById("darkModeToggle").checked = true;

        document.querySelector("#logotype").setAttribute("src", "/images/solid.svg");

        const errorImg = document.querySelector("#errorImg");
        if (errorImg) {
            errorImg.setAttribute("src", "/images/error-404-darkmode.svg");
        }

        const singleCourseIcons = document.querySelectorAll("#programDetailsImg");
        if (singleCourseIcons != null) {
            singleCourseIcons.forEach(icon => {
                const darkIcon = icon.getAttribute("data-darksrc")
                icon.setAttribute("src", darkIcon)
            })
        }

        if (url === "/Contact") {
            header.style.backgroundColor = "#0f121e";
        } else {
            header.style.backgroundColor = "#0B0F19";
        }
    }
    else {
        body.classList.remove('dark-mode');
        document.getElementById("darkModeToggle").checked = false;
        document.querySelector("#logotype").setAttribute("src", "/images/logotype.svg");

        header.style.backgroundColor = "#FFFFFF";

        const errorImg = document.querySelector("#errorImg");
        if (errorImg) {
            errorImg.setAttribute("src", "/images/error-404.svg");
        }

        const singleCourseIcons = document.querySelectorAll("#programDetailsImg");
        if (singleCourseIcons != null) {
            singleCourseIcons.forEach(icon => {
                const lightIcon = icon.getAttribute("data-lightsrc")
                icon.setAttribute("src", lightIcon)
            })
        }

        if (url === "/Contact") {
            header.style.backgroundColor = "#F3F6FF";
        } else {
            header.style.backgroundColor = "#FFFFFF";
        }
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