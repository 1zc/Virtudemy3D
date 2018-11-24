using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class Dropdown : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public GameObject ClassRoomOption;
    public GameObject SubjectOption;

	public RectTransform container;
    public RectTransform cont;
	public bool isOpen;

	public void OnPointerEnter (PointerEventData eventData)
	{
		isOpen = true;
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		isOpen = false;
	}

	void Start () {

		container = transform.Find ("container").GetComponent<RectTransform> ();
        cont = transform.Find("cONT").GetComponent<RectTransform>();
        isOpen = false;		
	}

	void Update ()
    {		
		Vector3 scale = container.localScale;
		scale.y = Mathf.Lerp(scale.y, isOpen ? 1: 0, Time.deltaTime * 12);
		container.localScale = scale;

        if (ClassRoomOption.GetComponent<EmptyFile>().enabled)
        {
            isOpen = false;
            ClassRoomOption.GetComponent <EmptyFile>().enabled = false;
        }

        if (SubjectOption.GetComponent<EmptyFile>().enabled)
        {
            isOpen = false;
            SubjectOption.GetComponent<EmptyFile>().enabled = false;
        }
	}
}
