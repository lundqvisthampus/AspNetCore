document.addEventListener('DOMContentLoaded', function () {
    let sw = document.querySelector("#darkModeToggle")

    sw.addEventListener('change', function () {
        let theme = this.checked ? "dark" : "light"

        fetch(`/sitesettings/changetheme?mode=${theme}`)
            .then(res => {
                if (res.ok)
                    window.location.reload()
                else
                    console.log('something')
            })
    })
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