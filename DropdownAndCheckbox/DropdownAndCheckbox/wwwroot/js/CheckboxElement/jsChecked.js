window.onload = function () {
    onCheckedAll();
};

function onCheckedAll() {
    $("#checkAll").click(function () {
        $('input:checkbox').not(this).prop('checked', this.checked);
    });
}