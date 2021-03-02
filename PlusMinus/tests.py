from main import plusMinus
import unittest

class Tests(unittest.TestCase):
    def test_2positive0negative0zero(self):
        """Check 2 positive 0 negative 0 zero"""
        self.assertTrue(plusMinus([5,10])[0]== '%.6f'%1.000000)
        self.assertTrue(plusMinus([5,10])[1]== '%.6f'%0.000000)
        self.assertTrue(plusMinus([5,10])[2]== '%.6f'%0.000000)
    def test_0positive0negative0zero(self):
        """Check 0positive 0negative 0 zero"""
        self.assertTrue(plusMinus([])[0]== '%.6f'%0.000000)
        self.assertTrue(plusMinus([])[0]== '%.6f'%0.000000)
        self.assertTrue(plusMinus([])[0]== '%.6f'%0.000000)

    def test_2positive5negative3zero(self):
        self.assertTrue(plusMinus([1,-5,-4,-8,9,-7,0,-6,0,0])[0]== '%.6f'%(2/10))
        self.assertTrue(plusMinus([1,-5,-4,-8,9,-7,0,-6,0,0])[1]== '%.6f'%(5/10))
        self.assertTrue(plusMinus([1,-5,-4,-8,9,-7,0,-6,0,0])[2]== '%.6f'%(3/10))



if __name__ == "__main__":
    unittest.main()