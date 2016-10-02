$(document).ready(function() {
    var menuLi = $("#side-panel-ul > a");

    $(menuLi).hover(
        function() {
            $(this).animate({ backgroundColor: "#00c6ff" }, 50);
        },
        function() {
            $(this).animate({ backgroundColor: "#202020" }, 50);
        }
    );
});