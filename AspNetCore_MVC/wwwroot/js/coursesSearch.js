const input = document.querySelector("#courseSearch")
const courses = document.querySelectorAll(".oneCourse")

input.addEventListener("keyup", () => {
    const searchText = input.value.trim().toLowerCase();

    courses.forEach(course => {
        const title = course.querySelector(".header5").textContent.toLowerCase();
        const author = course.querySelector(".author").textContent.toLowerCase();

        if (searchText == "" || title.includes(searchText) || author.includes(searchText)) {
            course.classList.remove('hide');
        }
        else {
            course.classList.add('hide');
        }
    });
})