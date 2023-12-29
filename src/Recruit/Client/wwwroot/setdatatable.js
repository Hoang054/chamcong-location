$(document).ready(function () {

    //setTable = () => {
    //    $('#myTable').DataTable({
    //        paging: false,
    //        columnDefs: [
    //            { width: 200, targets: 0 }
    //        ],
    //        fixedColumns: true,
    //        searching: false
    //    });
    //}
    //setInputDate = () => {
    //    $('.date').datepicker({
    //        format: 'dd-mm-yyyy'
    //    });
    //    $('.date').css('z-index', 999);
    //    $('#txtDate').datepicker({
    //        format: "dd/mm/yyyy"
    //    });
    //}
 
    getCoordinates = () => {
        return new Promise(function (resolve, reject) {
            navigator.geolocation.getCurrentPosition(resolve, reject);
        });
    };

    getGeoLocation = async () => {
        // Check if geolocation is supported by the browser
        if ("geolocation" in navigator) {
            try {
                const position = await getCoordinates();
                let lat = position.coords.latitude;
                let lng = position.coords.longitude;

                return { Latitude: lat.toString(), longitude: lng.toString() };
            }
            catch {
                showAlert();
            }
        } else {
            // Geolocation is not supported by the browser
            console.error("Geolocation is not supported by this browser.");
        }
    }

    showAlert = () => {
        alert("Please allow geolocation!");
    }
});