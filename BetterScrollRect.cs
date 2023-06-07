using UnityEngine;
using UnityEngine.UI;

public static class BetterScrollRect
{
    public static void ResizeContent(this ScrollRect scrollRect, int verticalPadding = 0)
    {
        if (scrollRect.content == null)
        {
            Debug.LogError("Content Transform reference is missing!");
            return;
        }

        RectTransform content = scrollRect.content;

        // Calculate the total height required to fit all the children and their spacing
        float totalHeight = 0f;
        int childCount = content.childCount;
        float spacing = content.GetComponent<VerticalLayoutGroup>()?.spacing ?? 0f; // Get spacing if a VerticalLayoutGroup component is attached

        for (int i = 0; i < childCount; i++)
        {
            RectTransform child = content.GetChild(i) as RectTransform;
            totalHeight += GetChildSize(child);

            if (i < childCount - 1)
            {
                totalHeight += spacing;
            }
        }

        // Set the new size of the content Transform
        Vector2 newSize = content.sizeDelta;
        newSize.y = totalHeight + verticalPadding;
        content.sizeDelta = newSize;
    }

    private static float GetChildSize(RectTransform child)
    {
        // Calculate the size of the child based on its position and size
        Vector2 childPosition = child.anchoredPosition;
        Vector2 childSize = child.sizeDelta;

        float childTop = childPosition.y + childSize.y;
        float childBottom = childPosition.y;

        return childTop - childBottom;
    }

    public static void ScrollContentToBottom(this ScrollRect scrollRect)
    {
        if (scrollRect.content == null)
        {
            Debug.LogError("Content Transform reference is missing!");
            return;
        }

        RectTransform content = scrollRect.content;

        // Calculate the position to scroll to
        Vector2 scrollTo = new Vector2(0f, content.sizeDelta.y - scrollRect.viewport.rect.height);

        // Set the content's anchored position to scroll to the bottom
        content.anchoredPosition = scrollTo;
    }
}
