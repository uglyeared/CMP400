using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using Unity.XR.OpenVR;

public class RadialMenuScript : MonoBehaviour
{

    public int noOfSections;
    public GameObject section;
    public Transform canvas;
    public float space;
    public Transform hand;
    private int selectedSection =-1;
    public UnityEvent<int> onSelected;
    public InputActionReference selectSpawn;

    private List<GameObject> spawnedSections = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (selectSpawn.action.IsPressed() && selectSpawn.action.WasPressedThisFrame())
        //{
        //    CreateSection();
        //}

        //if (selectSpawn.action.IsPressed())
        //{
        //    getSection();
        //}

        //if (selectSpawn.action.IsPressed() == false && selectSpawn.action.WasPressedThisFrame() == false)
        //{
        //    Selected();
        //}

        CreateSection();



    }

    public void Selected()
    {
        onSelected.Invoke(selectedSection);
        canvas.gameObject.SetActive(false);
    }
    public void getSection()
    {
        Vector3 placeHand = hand.position - canvas.position;
        Vector3 handProj = Vector3.ProjectOnPlane(placeHand, canvas.forward);

        float angle = Vector3.SignedAngle(canvas.up, handProj, -canvas.forward);
        selectedSection = (int)angle * noOfSections / 360;

        if(angle  < 0)
        {
            angle += 360;
        }

        for (int i = 0; i < spawnedSections.Count; i++)
        {

            if (i == selectedSection)
            {
                spawnedSections[i].GetComponent<Image>().color = Color.yellow;
                spawnedSections[i].transform.localScale = 1.1f * Vector3.one;
            }
            else
            {

                spawnedSections[i].GetComponent<Image>().color = Color.white;
                spawnedSections[i].transform.localScale = Vector3.one;
            }
        }
    }
    public void CreateSection()
    {
        canvas.gameObject.SetActive(true); 
        canvas.position = hand.position;
        canvas.rotation = hand.rotation;

        foreach (var item in spawnedSections)
        {
            Destroy(item);
        }
        spawnedSections.Clear();




        for (int i = 0; i < noOfSections; i++) // full circle /number of parts, determines size of each section creates each section then transforms and fills by the amount calculated
        {
            float angle = - i * 360 / noOfSections; 
            Vector3 sectionAngle = new Vector3(0,0,angle);
            GameObject createdSection = Instantiate(section,canvas);
            createdSection.transform.position = canvas.position;
            createdSection.transform.localEulerAngles = sectionAngle;
            createdSection.GetComponent<Image>().fillAmount = (1/(float)noOfSections)-(space/360);
            spawnedSections.Add(createdSection);
        }
    }
}
