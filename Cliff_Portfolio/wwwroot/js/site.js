var main = document.getElementById("main");

function main_display(section_name) {
    main.innerHTML = "";

    $.ajax({
        type: "GET",
        url: '?handler=Section&section=' + section_name,
        success: function (result) {
            main.insertAdjacentHTML("afterbegin", result);
        },
        error: function (error) {
            alert("Error: " + error);
        }
    })
}