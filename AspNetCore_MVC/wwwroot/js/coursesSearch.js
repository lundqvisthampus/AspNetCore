const input = document.querySelector("#courseSearch")
const select = document.querySelector(".select-input")
const courses = document.querySelectorAll(".oneCourse")
const numbersDiv = document.querySelector(".page-numbers")


input.addEventListener("change", () => {
    const searchText = input.value.trim().toLowerCase();
    window.location.href = `/Courses/Index?search=${searchText}`
})

select.addEventListener("change", () => {
    const option = select.options[select.selectedIndex].text;
    window.location.href = `/Courses/Index?select=${option}`
})

const urlParams = new URLSearchParams(window.location.search);
const selectOptionFromUrl = urlParams.get("select");

if (selectOptionFromUrl) {
    for (let i = 0; i < select.options.length; i++) {
        if (select.options[i].text === selectOptionFromUrl) {
            select.selectedIndex = i;
            break;
        }
    }
}


document.addEventListener('DOMContentLoaded', () => {
    const numberButton = document.querySelectorAll('.number');
    const queryString = window.location.search;
    const urlParam = new URLSearchParams(queryString)
    const page = urlParam.get('pageNumber');

    numberButton.forEach(function (number) {
        if (page == number.textContent || page == null) {
            number.classList.add('active');
        }
    })
})