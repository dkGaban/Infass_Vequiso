$(document).ready(function () {
    var controller = new UserController();

    $('#registerButton')
        .removeAttr('onclick')
        .on('click', function () {
            controller.register();
        });
});
