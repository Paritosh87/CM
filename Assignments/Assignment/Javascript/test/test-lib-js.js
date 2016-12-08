var assert = require('assert');
var lib = require('../lib/lib-js.js');

describe('Check startsWith', function() {
  it('returns true as a valid string is entered as input', function() {
    var result = "paritosh".startsWith("pari");

    assert.equal(result, true, 'Paritosh.startsWith("Pari")');
  });
  
  it('returns false as a invalid string is entered as input', function(){
    var result = "paritosh".startsWith("something else");

   assert.equal(result, false, '"paritosh".startsWith("something else")')
  });
});

describe('Check endsWith', function() {
  it('returns true as a valid string is entered as input', function() {
    var result = "paritosh".endsWith("tosh");

    assert.equal(result, true, '"paritosh".endsWith("tosh")');
  });
  
  it('returns false as a invalid string is entered as input', function(){
    var result = "paritosh".endsWith("something else");

   assert.equal(result, false, '"paritosh".endsWith("something else")')
  });
});

describe('Check stripHtml', function() {
  it('returns true if all html tags are stripped for "<p>Shoplifters of the World <em>Unite</em>!</p>"', function() {
    var result = "<p>Shoplifters of the World <em>Unite</em>!</p>".stripHtml();

    assert.equal(result, "Shoplifters of the World Unite!", 'text still has html');
  });
  

});