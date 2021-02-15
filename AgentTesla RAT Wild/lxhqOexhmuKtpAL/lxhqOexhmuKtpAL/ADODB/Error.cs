using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000020 RID: 32
	[CompilerGenerated]
	[DefaultMember("Description")]
	[Guid("00000500-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier]
	[ComImport]
	public interface Error
	{
		// Token: 0x060002AB RID: 683
		void _VtblGap1_2();

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002AC RID: 684
		[DispId(0)]
		[IndexerName("Description")]
		string Description { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
