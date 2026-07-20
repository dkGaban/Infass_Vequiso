class UserController {
    getFormData() {
        return {
            fullName: $.trim($('#fullName').val()),
            email: $.trim($('#email').val()),
            gender: $('input[name="gender"]:checked').val() || '',
            age: $.trim($('#age').val()),
            address: $.trim($('#address').val()),
            username: $.trim($('#username').val()),
            password: $('#password').val(),
            confirmPassword: $('#confirmPassword').val()
        };
    }

    validate(data) {
        if (!data.fullName) {
            alert('Please enter your Full Name.');
            return false;
        }
        if (!data.email) {
            alert('Please enter your Email Address.');
            return false;
        }
        if (!data.gender) {
            alert('Please select your Gender.');
            return false;
        }
        if (!data.age) {
            alert('Please enter your Age.');
            return false;
        }
        if (!data.address) {
            alert('Please enter your Complete Address.');
            return false;
        }
        if (!data.username) {
            alert('Please enter a Username.');
            return false;
        }
        if (!data.password) {
            alert('Please enter a Password.');
            return false;
        }
        if (!data.confirmPassword) {
            alert('Please confirm your Password.');
            return false;
        }
        if (data.password !== data.confirmPassword) {
            alert('Password and Confirm Password do not match.');
            return false;
        }
        return true;
    }

    register() {
        var data = this.getFormData();
        if (!this.validate(data)) return;

        $.ajax({
            url: '/Register/Register',
            type: 'POST',
            data: data,
            success: function (response) {
                if (response.success) {
                    var d = response.data;
                    alert(
                        'Registration Successful!\n\n' +
                        'Full Name: ' + d.fullName + '\n' +
                        'Email: ' + d.email + '\n' +
                        'Gender: ' + d.gender + '\n' +
                        'Age: ' + d.age + '\n' +
                        'Address: ' + d.address + '\n' +
                        'Username: ' + d.username
                    );
                } else {
                    alert(response.message);
                }
            },
            error: function () {
                alert('An error occurred. Please try again.');
            }
        });
    }
}
