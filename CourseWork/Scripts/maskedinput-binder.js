$(function () {
    $('[mask]').each(function (e) {
        $(this).mask($(this).attr('mask'));
    });
});
$(function () {
    $.mask.definitions['H'] = '[012]';
    $.mask.definitions['M'] = '[012345]';
    $('#time_start').mask('H9:M9', {
        placeholder: "_",
        completed: function () {
            var val = $(this).val().split(':');
            if (val[0] * 1 > 23) val[0] = '23';
            if (val[1] * 1 > 59) val[1] = '59';
            $(this).val(val.join(':'));
        }
    }
    );
});