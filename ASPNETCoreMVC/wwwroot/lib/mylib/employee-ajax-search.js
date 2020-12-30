$(function () {
    $("btnSearch").click(function () {
        var searchItem = $("SearchItem").val();
        var searchString = $("SearchString").val();
        var searchResults = $("#SearchResults");
        searchResults.html("");
        $.ajax({
            type: "post",
            url: "/home/EmployeeAjaxSearch/",
            contentType: "html",
            success: function (result) {
                if (result.length == 0) {
                    searchResults.append("<tr><td>No matching records found</td></tr>");
                }
                else {
                    $.each(result, function (index, value) {
                        var data = "<tr>" +
                            "<td>" + value.id + "</td>" +
                            "<td>" + value.EmpName + "</td>" +
                            "<td>" + value.Salary + "</td>" +
                            "<td>" + value.DeptNo + "</td>" +
                            "</tr>"
                        searchResults.append(result);
                    });
                }
            }
        });
    });
});