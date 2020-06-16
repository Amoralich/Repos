
$(function () {
	var box = $("#searching");
	var ajaxFormSubmit = function () {
		var $form = $(this);
		var options = {
			url: $form.attr("action"),
			type: $form.attr("method"),
			data:$form.serialize()
		};
		var $target = $($form.attr("data-otf-target"));
		$target.slideUp(500);
		box.slideDown("slow", function () {
			$.ajax(options).done(function (data) {
				$target.replaceWith(data).promise().done(function () {
					box.slideUp("slow");
					$target.slideDown(500);
				});
			});
		});
		return false;
	};
	var submitAutocompleteForm = function (event, ui) {
		var $input = $(this);
		$input.val(ui.item.label);
		var $form = $input.parents("form:first");
		$form.submit();
	};
	var createAutocomplete = function () {
		var $input = $(this);
		var options = {
			source: $input.attr("data-otf-autocomplete"),
			select: submitAutocompleteForm
		};
		$input.autocomplete(options);
	};

	$("form[data-otf-ajax='true']").submit(ajaxFormSubmit);
	$("input[data-otf-autocomplete]").each(createAutocomplete);
});