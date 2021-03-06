﻿using Telegram.Td.Api;
using Unigram.Common;
using Unigram.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Unigram.Controls
{
    public class BubbleListViewItem : LazoListViewItem
    {
        public readonly BubbleListView Messages;

        public BubbleListViewItem(BubbleListView messages)
            : base(messages)
        {
            Messages = messages;
        }

        #region ContentMargin

        public Thickness ContentMargin
        {
            get { return (Thickness)GetValue(ContentMarginProperty); }
            set { SetValue(ContentMarginProperty, value); }
        }

        public static readonly DependencyProperty ContentMarginProperty =
            DependencyProperty.Register("ContentMargin", typeof(Thickness), typeof(BubbleListViewItem), new PropertyMetadata(default(Thickness)));

        #endregion

        protected override void OnPointerPressed(PointerRoutedEventArgs e)
        {
            if (Messages.SelectionMode == ListViewSelectionMode.Multiple)
            {
                if (Content is FrameworkElement element && element.Tag is MessageViewModel message && message.IsService())
                {
                    e.Handled = true;
                }

                //if (Content is TLMessageService serviceMessage)
                //{
                //    e.Handled = true;
                //}
                //else if (Content is TLMessage message)
                //{
                //    if (message.Media is TLMessageMediaDocument documentMedia && documentMedia.HasTTLSeconds)
                //    {
                //        e.Handled = true;
                //    }
                //}
            }

            base.OnPointerPressed(e);
        }
    }
}
