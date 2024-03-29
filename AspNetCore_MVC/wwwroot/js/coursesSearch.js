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



const select = document.querySelector(".select-input")

select.addEventListener("change", () => {
    const option = select.options[select.selectedIndex].text;

    if (option == "Best seller") {

        courses.forEach(course => {
            const bestSeller = course.querySelector(".bestSeller");
            if (bestSeller != null) {
                course.classList.remove('hide');
            }
            else {
                course.classList.add('hide');
            }
        })
    }

    else if (option == "All categories") {
        courses.forEach(course => {
            course.classList.remove('hide');
        })
    }

    else if (option == "Reduced price") {

        courses.forEach(course => {
            const reducedPrice = course.querySelector(".reducedPrice");
            if (reducedPrice != null) {
                course.classList.remove('hide');
            }
            else {
                course.classList.add('hide');
            }
        })
    }

    else if (option == "Saved courses") {

        courses.forEach(course => {
            const savedCourse = course.querySelector("#deleteCourseBtn");
            if (savedCourse != null) {
                course.classList.remove('hide');
            }
            else {
                course.classList.add('hide');
            }
        })
    }
})