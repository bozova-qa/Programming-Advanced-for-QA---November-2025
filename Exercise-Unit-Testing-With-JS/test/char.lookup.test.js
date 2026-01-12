import {lookupChar} from '../charLookup.js'
import{describe} from 'mocha'
import{expect, assert} from 'chai'

describe('Test_charLookUp', () => {
    it('should return undefined if first parameter is undefined', () => {
        expect(lookupChar(42, 5)).to.be.undefined;
        expect(lookupChar([], 5)).to.be.undefined;
        expect(lookupChar({}, 5)).to.be.undefined;
        expect(lookupChar(null, 5)).to.be.undefined;
        expect(lookupChar(undefined, 5)).to.be.undefined;
    }),

    it('should return undefined if second parameter is not an integer', () => {
        expect(lookupChar('hello', '2')).to.be.undefined;
        expect(lookupChar('hello', 5.6)).to.be.undefined;
        expect(lookupChar('hello', [4])).to.be.undefined;
        expect(lookupChar('hello', {})).to.be.undefined;
        expect(lookupChar('hello', null)).to.be.undefined;
        expect(lookupChar('hello', undefined)).to.be.undefined;
    }),

    it('should return incorrect index of index is out of range', () => {
        // Arrange
        let expected = 'Incorrect index';

        // Act & assert
        expect(lookupChar('hello', -1)).to.equal(expected); // negative index
        expect(lookupChar('hello', 5)).to.equal(expected); // index equal length
        expect(lookupChar('hello', 10)).to.equal(expected); // index greater than length
    }),

    it('should return character if all parameters are valid', () => {
        expect(lookupChar("Nade", 0)).to.be.equal('N');
        expect(lookupChar("Nade", 2)).to.be.equal('d');
        expect(lookupChar("Nade", 3)).to.be.equal('e');
    })
})