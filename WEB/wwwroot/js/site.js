// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

setTimeout(() => {
    $(".notification").fadeOut("slow")
}, 3000)

setInterval(() => {
    loadEarnings()
}, 1000)

$("#uploadStudentImage").on("change", function () {
    if (this.files && this.files[0]) {
        $("#imageStudent").attr("src", URL.createObjectURL(this.files[0]))
    }
})
