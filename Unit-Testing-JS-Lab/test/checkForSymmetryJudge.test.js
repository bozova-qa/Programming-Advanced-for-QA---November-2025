import {isSymmetric} from '../checkForSymmetry.js'
import {expect, assert} from 'chai'

describe('Test function isSymmetric', () => {
    it ('should return false if input is not array', () => {
        
        expect(isSymmetric(1)).to.be.false;
        expect(isSymmetric(1, 3, 4)).to.be.false;
        expect(isSymmetric("Hello")).to.be.false;
        expect(isSymmetric(5.60)).to.be.false;
        expect(isSymmetric({name: "Ivan"})).to.be.false;
    }),

    it ('should return true if array is symmetric', () => {
        
        expect(isSymmetric([1, 2, 1])).to.be.true;
        expect(isSymmetric(["Desi", "Ivan", "Desi"])).to.be.true;
        expect(isSymmetric(["1", 2, 2, "1"])).to.be.true;
        expect(isSymmetric(["Desi", 5, 5, "Desi"])).to.be.true;
        expect(isSymmetric(["Desi", ['a'], ['a'], "Desi"])).to.be.true;
    }),

    it ('should return false if array is not symmetric', () => {
        
        expect(isSymmetric([1, 2, 3])).to.be.false;
        expect(isSymmetric(["Desi", "Ivan", "Georgi"])).to.be.false;
        expect(isSymmetric(["1", 2, "1", 2])).to.be.false;
        expect(isSymmetric(["1", [2], "1", 2])).to.be.false;
        expect(isSymmetric(["1", 5.60, "1", 2])).to.be.false;
    })
});