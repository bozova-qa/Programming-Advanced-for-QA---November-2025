import { analyzeArray } from "../arrayAnalyzer.js";
import { expect, assert } from 'chai';

describe('test_arrayAnalizer', () => {
    it('should return undefined if input is not an array or empty array', () => {
        expect(analyzeArray(42)).to.be.undefined;
        expect(analyzeArray('text')).to.be.undefined;
        expect(analyzeArray({})).to.be.undefined;
        expect(analyzeArray(null)).to.be.undefined;
        expect(analyzeArray(undefined)).to.be.undefined;

        expect(analyzeArray([])).to.be.undefined;//empty
    }),
    it('should return object if input is a single element array', () => {
        expect(analyzeArray([42]).min).to.equal(42);
        expect(analyzeArray([42]).max).to.equal(42);
        expect(analyzeArray([42]).length).to.equal(1);

        //директно сравнение
        //assert.deepEqual(analyzeArray([42]), { min: 5, max: 5, length: 1})

    }),
    it('if input is equal elements array', () => {
        expect(analyzeArray([5, 5, 5, 5]).min).to.equal(5);
        expect(analyzeArray([5, 5, 5, 5]).max).to.equal(5);
        expect(analyzeArray([5, 5, 5, 5]).length).to.equal(4);
    }), 
    it('if input is an array of numbers', () => {
        expect(analyzeArray([1, 2, 3, 4]).min).to.equal(1);
        expect(analyzeArray([1, 2, 3, 4]).max).to.equal(4);
        expect(analyzeArray([1, 2, 3, 4]).length).to.equal(4);
    })
});