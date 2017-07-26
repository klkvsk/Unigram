// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.uploadMedia.
	/// Returns <see cref="Telegram.Api.TL.TLMessageMediaBase"/>
	/// </summary>
	public partial class TLMessagesUploadMedia : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public TLInputMediaBase Media { get; set; }

		public TLMessagesUploadMedia() { }
		public TLMessagesUploadMedia(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesUploadMedia; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Media = TLFactory.Read<TLInputMediaBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x519BC2B1);
			to.WriteObject(Peer);
			to.WriteObject(Media);
		}
	}
}