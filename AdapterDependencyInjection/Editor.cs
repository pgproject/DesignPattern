using System.Collections.Generic;

namespace AdapterDependencyInjection
{
    public class Editor
    {
        private IEnumerable<Button> m_buttons;

        public IEnumerable<Button> Buttons => m_buttons;
        
        public Editor(IEnumerable<Button> mButtons)
        {
            m_buttons = mButtons;
        }

        public void ClickAll()
        {
            foreach (var btn in m_buttons)
            {
                btn.Click();
            }
        }
    }
}