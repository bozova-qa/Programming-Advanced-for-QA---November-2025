import { artGallery } from "../artGallery.js";
import { expect, assert } from 'chai';

describe.only('tests_artGallery', () => {
    describe('test_addArtwork', () => {
        it('should throw error if title is not a string', () => {
            let errorMessage = "Invalid Information!";
            expect(() => artGallery.addArtwork(42, '50 x 70', 'Picasso')).to.throw(errorMessage)
            expect(() => artGallery.addArtwork([], '50 x 70', 'Picasso')).to.throw(errorMessage)
            expect(() => artGallery.addArtwork({}, '50 x 70', 'Picasso')).to.throw(errorMessage)
            expect(() => artGallery.addArtwork(null, '50 x 70', 'Picasso')).to.throw(errorMessage)
        }),

        it('should throw an error if type of artist is not a string', () => {
            let errorMessage = "Invalid Information!";
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', 42)).to.throw(errorMessage)
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', [])).to.throw(errorMessage)
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', {})).to.throw(errorMessage)
            expect(() => artGallery.addArtwork('Guernica', '50 x 70', null)).to.throw(errorMessage)
        }),
        it('should throw an error if dimensions are not in a correct format', () => {
            let errorMessage = "Invalid Dimensions!";
            expect(() => artGallery.addArtwork('Guernica', 42, 'Picasso')).to.throw(errorMessage)
            expect(() => artGallery.addArtwork('Guernica', [30, 50], 'Picasso')).to.throw(errorMessage)
            expect(() => artGallery.addArtwork('Guernica', '30x40', 'Picasso')).to.throw(errorMessage)
            expect(() => artGallery.addArtwork('Guernica', '75x 50', 'Picasso')).to.throw(errorMessage)
            expect(() => artGallery.addArtwork('Guernica', '75 X50', 'Picasso')).to.throw(errorMessage)
        }),
        it('should throw an error if artist is not allowed', () => {
            
            // Arrange
            let invalidArtists = 'V.D. Maistora'
            let errorMessage = "This artist is not allowed in the gallery!";

            // Act & Assert
            expect(() => artGallery.addArtwork('Guernica', '75 x 50', invalidArtists)).to.throw(errorMessage)
        }),
        it('should return proper message if input is valid', () => {
            let message = `Artwork added successfully: 'Guernica' by Picasso with dimensions 50 x 70.`

            expect(artGallery.addArtwork('Guernica', '50 x 70', 'Picasso')).to.equal(message)
        })


    });

    describe('test_calculateCosts', () => {
        it('should throw an error if exhibitionCosts is not a number', () => {
            let errorMessage = "Invalid Information!";
            expect(() => artGallery.calculateCosts('50000', 30000, true)).to.throw(errorMessage)
            expect(() => artGallery.calculateCosts(-50000, 30000, true)).to.throw(errorMessage)
        }),

        it('should throw an error if insuranceCosts is not a number', () => {
            let errorMessage = "Invalid Information!";
            expect(() => artGallery.calculateCosts(50000, '30000', true)).to.throw(errorMessage)
            expect(() => artGallery.calculateCosts(50000, -30000, true)).to.throw(errorMessage)
        }),

        it('should throw an error if sponsor is not a boolean', () => {
            let errorMessage = "Invalid Information!";
            expect(() => artGallery.calculateCosts(50000, 30000, 'true')).to.throw(errorMessage)
            expect(() => artGallery.calculateCosts(50000, 30000, 'false')).to.throw(errorMessage)
        }),
        it('with sponsor (true)', () => {
            let message = `Exhibition and insurance costs are 72000$, reduced by 10% with the help of a donation from your sponsor.`
            expect(artGallery.calculateCosts(50000, 30000, true)).to.equal(message)
        }),
        it('with sponsor (false)', () => {
            let message = `Exhibition and insurance costs are 80000$.`
            expect(artGallery.calculateCosts(50000, 30000, false)).to.equal(message)
        })
    });

    describe('test_organizeExhibits', () => {
        it('should throw error if first parameter is not a number or negative', () => {
            let errorMessage = "Invalid Information!"
            expect(() => artGallery.organizeExhibits('20', 40)).to.throw(errorMessage)
            expect(() => artGallery.organizeExhibits(-20, 40)).to.throw(errorMessage)
            expect(() => artGallery.organizeExhibits(0, 40)).to.throw(errorMessage)
        }),

        it('should throw error if second parameter is not a number or negative', () => {
            let errorMessage = "Invalid Information!"
            expect(() => artGallery.organizeExhibits(20, '40')).to.throw(errorMessage)
            expect(() => artGallery.organizeExhibits(20, -40)).to.throw(errorMessage)
            expect(() => artGallery.organizeExhibits(20, 0)).to.throw(errorMessage)

        }),
        it('if result is lower than 5', () => {
            let message = `There are only 3 artworks in each display space, you can add more artworks.`
            expect(artGallery.organizeExhibits(24, 7)).to.equal(message)
        }),
        it('if result is greater than 5', () => {
            let message = `You have 7 display spaces with 9 artworks in each space.`
            expect(artGallery.organizeExhibits(67, 7)).to.equal(message)
        })
    });
})
