var Lock = function () {

    return {
        //main function to initiate the module
        init: function () {

             $.backstretch([
		        "/Content/custom/bg/1.jpg",
		        "/Content/custom/bg/2.jpg",
		        "/Content/custom/bg/3.jpg",
		        "/Content/custom/bg/4.jpg",
		        "/Content/custom/bg/5.jpg",
		        "/Content/custom/bg/6.jpg",
		        "/Content/custom/bg/7.jpg"
		        ], {
		          fade: 1000,
		          duration: 8000
		      });
        }

    };

}();