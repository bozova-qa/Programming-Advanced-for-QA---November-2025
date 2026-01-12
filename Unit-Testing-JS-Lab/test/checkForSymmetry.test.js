import {isSymmetric} from '../checkForSymmetry.js'
import {expect, assert} from 'chai'

describe('Test function isSymmetric', () => {
    it ('should return false if input is not array', () => {
        //Arrange
        let name = "test";
      
        //Act
        let result = isSymmetric(name);

        //Assert
        assert.equal(result, false);
        expect(result).to.be.false;//можем и двете да ползваме
    }),

    it ('should return true if array is symmetric', () => {
        // Arrange
        let array = [1, 2, 2, 1];

        // Act
        let result = isSymmetric(array);

        // Assert
        assert.equal(result, true);
        expect(result).to.be.true;//можем и двете да ползваме

    }),

    it ('should return false if array is not symmetric', () => {
        // Arrange
        let array = [1, 2, 3, 4];

        // Act
        let result = isSymmetric(array);

        // Assert
        assert.equal(result, false);
        expect(result).to.be.false;//можем и двете да ползваме

    })
});