using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class treePlanting : MonoBehaviour
{
    // a pool for the trees
    private List<GameObject> trees = new List<GameObject>();

    /*
     * define the number of trees in each plot.
     * The last number means the average number of trees in 14 plots.
     * This is not used right now since we use density to calculate number of trees
     */
    //private int[] plotTreeNumbers = { 178, 235, 178, 213, 432, 432, 213, 118, 235, 118, 178, 235, 213, 432, 243};

    /*
     * define heights of different tree models when scale is one
     * HSR : height scal ratio
     * Unit: meter
     * The values here are not magic numbers, they are measures in unity editor
     */
    private double redPineHSR = 25.0;         private double oakHSR = 17.2 / 2;
    private double beechHSR = 35.47 / 2;      private double birchHSR = 22.18 / 2;
    private double redMapleHSR = 14.12 / 2;   private double whitePineHSR = 64.4 / 2;
    private double redOakHSR = 18.95 / 2;


    /*
     * Define plot information
     */
    private double sideLength = 100.0;
    private float startingCoordinate = 1f;
    private float endingCoordinate = 99f;
    

    // a collection of tree positions
    private Vector3[] treelocal;

    // including all the data about the plot
    public DataModel data;

    // season controller --> get seasonal information
    public SeasonController seasonController;

    /*
     * A list that contains all the tree model prefabs
     * Index 0 --> Red Pine
     * Index 1 --> Oak
     * Index 2 --> Beech
     * Index 3 --> Birch
     * Index 4 --> Red Maple
     * Index 5 --> White Pine
     * Index 6 --> Red Oak
     */

    /* Treefabs with leaves */
    public List<GameObject> treeprefabsWL;

    /* Treefabs without leaves */
    public List<GameObject> treeprefabsWOL;


    // calculate tree number of different tree type
    private int[] calculatedTreeNumbers()
    {
        double area = sideLength * sideLength;

        int[] treenumbers = {
            Convert.ToInt32( Convert.ToDouble(data.RedPineData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.OakData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.BeechData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.BirchData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.RedMapleData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.WhitePineData.Density) * area ),
            Convert.ToInt32( Convert.ToDouble(data.RedOakData.Density) * area ),
        };
        return treenumbers;
    }

    /*
     * generate locations when tree distribution follows square distribution
     * input: number of locations
     */
    private void generateSquareLocation(int numberOfPoints)
    {
        treelocal = new Vector3[numberOfPoints];

        int i;

        for (i = 0; i < treelocal.Length; i++)
        {
            treelocal[i] = new Vector3(UnityEngine.Random.Range(startingCoordinate, endingCoordinate),
                                       0f,
                                       UnityEngine.Random.Range(startingCoordinate, endingCoordinate));
        }
    }

    /*
     * generate locations when tree distribution follows circle distribution
     * input1: a list of circles
     * input2: number of locations
     */
    private void generateCircleLocation(List<Circle> circles,  int numberOfPoints)
    {
        treelocal = new Vector3[numberOfPoints];
        int counter = 0;
       
        while (counter < numberOfPoints)
        {
            Point randomPoint = new Point(UnityEngine.Random.Range(startingCoordinate, endingCoordinate),
                                          UnityEngine.Random.Range(startingCoordinate, endingCoordinate));
            if(! isPointInCircles(circles, randomPoint))
            {
                continue;
            }
            treelocal[counter] = new Vector3((float)randomPoint.getX(), 0f, (float)randomPoint.getY());
            counter++;
        }
       
    }

    /*
     * Given a list of circles and a point
     * Check if this point is in any circle from the list
     */
    private bool isPointInCircles(List<Circle> circles, Point point)
    {
        foreach (Circle circle in circles)
        {
            if (circle.isIn(point))
            {
                return true;
            }
        }
        return false;
    }
   
    // remove all the trees
    public void cleanTrees()
    {
        if (trees.Count == 0)
        {
            return;
        }
        trees.ForEach(it => { Destroy(it); });
        trees.Clear();
    }



    /*
     * plant trees
     * input: plot number
     */
    public void plantTrees(int plotNumberIndex)
    {
        //first step: clean the trees from the previous plot
        cleanTrees();

        /*
         * Second step: calculate the number of trees for different types of trees
         * Index 0 --> Red Pine
         * Index 1 --> Oak
         * Index 2 --> Beech
         * Index 3 --> Birch
         * Index 4 --> Red Maple
         * Index 5 --> White Pine
         * Index 6 --> Red Oak
         */
        int[] differentTreeNumbers = calculatedTreeNumbers();

        

        /*
        * Third step: generate tree locations
        */
        if (plotNumberIndex == 0)
        {
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(new Point(72, 23), 14.0));
            circles.Add(new Circle(new Point(34, 28), 21.0));
            circles.Add(new Circle(new Point(71, 70), 19.0));
            circles.Add(new Circle(new Point(33, 79), 13.0));
            generateCircleLocation(circles, differentTreeNumbers.Sum());
        }
        else if (plotNumberIndex == 2)
        {
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(new Point(73, 18), 15.0));
            circles.Add(new Circle(new Point(14, 10), 17.0));
            circles.Add(new Circle(new Point(78, 77), 21.0));
            circles.Add(new Circle(new Point(43, 84), 13.0));
            generateCircleLocation(circles, differentTreeNumbers.Sum());
        }
        else if (plotNumberIndex == 3)
        {
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(new Point(66, 25), 31.0));
            circles.Add(new Circle(new Point(17, 15), 15.0));
            circles.Add(new Circle(new Point(80, 68), 16.0));
            circles.Add(new Circle(new Point(35, 69), 34.0));
            generateCircleLocation(circles, differentTreeNumbers.Sum());
        }
        else if (plotNumberIndex == 6)
        {
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(new Point(71, 23), 33.0));
            circles.Add(new Circle(new Point(32, 50), 17.0));
            circles.Add(new Circle(new Point(90, 87), 16.0));
            circles.Add(new Circle(new Point(28, 93), 40.0));
            generateCircleLocation(circles, differentTreeNumbers.Sum());
        }
        else if (plotNumberIndex == 10)
        {
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(new Point(68, 23), 22.0));
            circles.Add(new Circle(new Point(14, 11), 14.0));
            circles.Add(new Circle(new Point(67, 13), 17.0));
            circles.Add(new Circle(new Point(27, 86), 27.0));
            generateCircleLocation(circles, differentTreeNumbers.Sum());
        }
        else if (plotNumberIndex == 12)
        {
            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle(new Point(67, 22), 36.0));
            circles.Add(new Circle(new Point(21, 25), 10.0));
            circles.Add(new Circle(new Point(28, 92), 50.0));
            generateCircleLocation(circles, differentTreeNumbers.Sum());
        }
        else
        {
            generateSquareLocation(differentTreeNumbers.Sum());
        }


        int posIndex = 0;
        double treeHeight;
        double standardScale;
        float lowerBound;
        float upperBound;

        /*
         * use corresponding treefabs according to the seasonal information
         */
        List<GameObject> treeprefabs;
        if (seasonController.haveLeaves)
        {
            treeprefabs = treeprefabsWL;
        }
        else
        {
            treeprefabs = treeprefabsWOL;
        }

        

        /*
         * Plant Red Pines
         */
        treeHeight = Convert.ToDouble(data.RedPineData.Height);
        standardScale = treeHeight / redPineHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[0]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[0]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Oak Trees
         */
        treeHeight = Convert.ToDouble(data.OakData.Height);
        standardScale = treeHeight / oakHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[1]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[1]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Beech Trees
         */
        treeHeight = Convert.ToDouble(data.BeechData.Height);
        standardScale = treeHeight / beechHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[2]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[2]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Birch Trees
         */
        treeHeight = Convert.ToDouble(data.BirchData.Height);
        standardScale = treeHeight / birchHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[3]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[3]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Red Maple
         */
        treeHeight = Convert.ToDouble(data.RedMapleData.Height);
        standardScale = treeHeight / redMapleHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[4]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[4]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant White Pine
         */
        treeHeight = Convert.ToDouble(data.WhitePineData.Height);
        standardScale = treeHeight / whitePineHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[5]; i++)
        {
            GameObject treeinstance = Instantiate(treeprefabs[5]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
            trees.Add(treeinstance);
            posIndex++;
        }


        /*
         * Plant Red Oak
         */
        treeHeight = Convert.ToDouble(data.RedOakData.Height);
        standardScale = treeHeight / redOakHSR;
        lowerBound = (float)(0.9 * standardScale);
        upperBound = (float)(1.1 * standardScale);
        for (int i = 0; i < differentTreeNumbers[6]; i++)
        {

            GameObject treeinstance = Instantiate(treeprefabs[6]);
            treeinstance.transform.position = treelocal[posIndex];
            float randomScale = UnityEngine.Random.Range(lowerBound, upperBound);
            treeinstance.transform.localScale = new Vector3(randomScale, randomScale, randomScale);

            /*
             * Modify tree color here
             * But only does this when there are leaves
             */
            if (seasonController.haveLeaves)
            {
                treeinstance.GetComponent<Renderer>().materials[1].color = new Color32(194, 31, 48, 255);
            }

            trees.Add(treeinstance);
            posIndex++;
        }
    }

}