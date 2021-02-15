using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200001C RID: 28
	[CompilerGenerated]
	[DefaultMember("ConnectionString")]
	[Guid("00000515-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier]
	[ComImport]
	public interface Connection15 : _ADO
	{
		// Token: 0x060002A7 RID: 679
		void _VtblGap1_1();

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002A8 RID: 680
		// (set) Token: 0x060002A9 RID: 681
		[DispId(0)]
		[IndexerName("ConnectionString")]
		string ConnectionString { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
