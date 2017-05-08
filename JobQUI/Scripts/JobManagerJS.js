
$(document).ready(function () {
 //Stops IE from caching table calls 
    $.ajaxSetup({ cache: false });
    loadTableRecurring();

    function loadTableRecurring() {
        $("#tables").load("/Home/TableData", setTimeout(loadTableRecurring, 10000));

    }
    function loadTable() {
        $("#tables").load("/Home/TableData");
 

    }

    $("#delete").click(function () {
        var guid = $(this).val();
       
        $.ajax({
            url: "Home/DeleteJob",
            type: "POST",
            data: { GUID: guid},
            success: function (result) {
                if (result.successful) {
                    loadTable();
                    $('#JobEditModal').modal('toggle');
                 
                }
                else {
                    alert("Failed to delete job");

                }
            }
        });
    });

    $(".delete").click(function () {
        var guid = $(this).val();
       
        $.ajax({
            url: "Home/DeleteJob",
            type: "POST",
            data: { GUID: guid },
            success: function (result) {
                if (result.successful) {
                    loadTable();
                    $('#JobEditModal').modal('toggle');
                   
                }
                else {
                    alert("Failed to delete job");

                }
            }
        });
    });

    $(".deleteExecuted").click(function () {
        var guid = $(this).val();

        $.ajax({
            url: "Home/DeleteJob",
            type: "POST",
            data: { GUID: guid },
            success: function (result) {
                if (result.successful) {
                    loadTable();
                    $('#JobDeleteModal').modal('toggle');

                }
                else {
                    alert("Failed to delete job");
                    $('#JobDeleteModal').modal('toggle');

                }
            }
        });
    });

    $(function () {
        $('#AddJobForm').submit(function () {
           
            $.ajax({
                url: "Home/AddJob",
                type: "POST",
                data: $(this).serialize(),
                success: function(result){
                    if (result.successful) {
                        loadTable();
                    }
                    else{
                        alert("Failed to add job");
                    }
                }
            });
            });

        });
  
    $(function () {
        $('#UpdateJobForm').submit(function () {
            $.ajax({
                url: "Home/UpdateJob",
                type: "POST",
                data: $(this).serialize(),
                success: function (result) {
                    if (result.successful) {
                        loadTable();
                        $('#JobEditModal').modal('toggle');
                    }
                    else {
                        alert("Failed to edit job");
                    }
                }
            });
        });

    });

    $('#JobEditModal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget) // Button that triggered the modal
        var guid = button.data('guid') // Extract info from data-* attributes
        var jobCmd = button.data('job')
        // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
        // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
        var modal = $(this)
        modal.find('.modal-title').text('Edit Job: '+ guid)
        modal.find('.modal-body #jobData').val(jobCmd)
        modal.find('.modal-body #guid').val(guid)
        modal.find('.delete').val(guid)

    })

    $('#JobDeleteModal').on('show.bs.modal', function (event) {
        var button = $(event.relatedTarget) // Button that triggered the modal
        var guid = button.data('guid') // Extract info from data-* attributes
        var jobCmd = button.data('job')
        // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
        // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
        var modal = $(this)
        modal.find('.modal-title').text('Delete Job: ' + guid)
        modal.find('.modal-body #guid').val(guid)
        modal.find('.deleteExecuted').val(guid)
    })

});

