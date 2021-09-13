$(document).ready(function () {
    $("#tb_F_Name").blur(() => {
        validateFName();
    });
    $("#tb_L_Name").blur(() => {
        validateLName();
    });
    $("#tb_Dob").blur(() => {
        validateDob();
    });
    $("#tb_Phone").blur(() => {
        validateMobile();
    });
    $("#tb_Email").blur(() => {
        validateEmail();
    });
    $("#tb_Locations").blur(() => {
        validateLocations();
    });
    $("#tb_Username").blur(() => {
        validateUsername();
    });
    $("#tb_Password").keydown(() => {
        $('#password').attr('type', 'password');
    });
    $("#tb_Password").blur(() => {
        validatePassword();
    });
    $("#reg").submit(function () {
        let state = validate();
        console.log(state);
        if (state === true) return true;
        else return false;
    });
});
function validateFName() {
    $(".FNameE").html("");
    var fname = $("#tb_F_Name").val();
    if (fname === "") {
        $(".FNameE").html("This field is required *").css({ color: "red" });
        return false;
    }
    return true;
}
function validateLName() {
    $(".LNameE").html("");
    var fname = $("#tb_L_Name").val();
    if (fname === "") {
        $(".LNameE").html("This field is required *").css({ color: "red" });
        return false;
    }
    return true;
}
function validateDob() {
    $(".DobE").html("");
    var fname = $("#tb_Dob").val();
    if (fname === "") {
        $(".DobE").html("This field is required *").css({ color: "red" });
        return false;
    }
    return true;
}
function validateMobile() {
    $(".MobileE").html("");
    var phoneno = new RegExp(/^\+?([0-9]{2})\)?[-. ]?([0-9]{5})[-. ]?([0-9]{5})$/);
    var mobileNumber = $("#tb_Phone").val();
    if (mobileNumber === "") {
        $(".MobileE").html("This field is required *").css({ color: "red" });
        return false;
    } else {
        if (!phoneno.test(mobileNumber)) {
            $(".MobileE").html("Invalid Mobile Number").css({ color: "red" });
            return false;
        }
    }
    return true;
}
function validateEmail() {
    $(".EmailE").html("");
    var email = $("#tb_Email").val();
    var emailRegEx = new RegExp(
        /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/
    );
    if (email === "") {
        $(".EmailE").html("This field is required *").css({ color: "red" });
        return false;
    } else {
        if (!emailRegEx.test(email)) {
            $(".EmailE").html("Invalid Email Address").css({ color: "red" });
            return false;
        }
    }
    return true;
}
function validateLocations() {
    $(".LocE").html("");
    var fname = $("#tb_Locations").val();
    if (fname === "") {
        $(".LocE").html("This field is required *").css({ color: "red" });
        return false;
    }
    return true;
}
function validateUsername() {
    $(".UserE").html("");
    var fname = $("#tb_Username").val();
    if (fname === "") {
        $(".UserE").html("This field is required *").css({ color: "red" });
        return false;
    }
    return true;
}
function validatePassword() {
    $(".PasswordE").html("");
    var password = $("#tb_Password").val();
    var passwordRegEx = new RegExp(
        /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])(?=.{8,18})/
    );
    if (password === "") {
        $(".PasswordE").html("This field is required *").css({ color: "red" });
        return false;
    }
    return true;
}
function validate() {
    var fname = validateFName();
    var lname = validateLName();
    var mobile = validateMobile();
    var email = validateEmail();
    var password = validatePassword();
    console.log(fname, lname, mobile, email, password);
    if (fname && lname && mobile && email && password) {
        return true;
    } else {
        return false;
    }
}