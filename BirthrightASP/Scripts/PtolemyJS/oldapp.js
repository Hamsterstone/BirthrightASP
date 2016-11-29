console.log('loading PtolemyJS and dependencies, please wait');

require.config({
	urlArgs: "bust=" +  (new Date()).getTime()
	});
// DEPENDENCIES
require(['Scripts/PtolemyJS/bower_components/raphael/raphael-min.js', 'Scripts/PtolemyJS/bower_components/Javascript-Voronoi/rhill-voronoi-core.min.js'], function () {
	require(['Scripts/PtolemyJS/bower_components/raphael-pan-zoom/src/raphael.pan-zoom.min.js'], function () {
		// CORE
		require(['Scripts/PtolemyJS/ptolemy/Ptolemy.js', 'Scripts/PtolemyJS/ptolemy/Cell.js', 'Scripts/PtolemyJS/ptolemy/util/util.js'], function () {
			// PLUGINS
			require(['Scripts/PtolemyJS/bower_components/noisejs/perlin.js', 'Scripts/PtolemyJS/ptolemy/plugins/Ptolemy.worldgeneration.js'], function () {

				main();
			});
		});

	});
});


function main () {

	window.engine = new Ptolemy('canvas');



	document.getElementById("randomMap").addEventListener("click", function( event ) {
		var n = document.getElementById("cellsCount").value;
		engine.newRandomWorld(n,16, function(){
			engine.render();
		});
	}, false);

	document.getElementById("exportMap").addEventListener("click", function( event ) {
		document.getElementById("mapInput").value = engine.exportMap();
	}, false);

	document.getElementById("importMap").addEventListener("click", function( event ) {
		engine.importMap(JSON.parse(document.getElementById("mapInput").value), function(){
			engine.render();
		});
	}, false);



}
