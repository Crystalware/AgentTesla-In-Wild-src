using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000030 RID: 48
	[CompilerGenerated]
	[DefaultMember("ConnectionString")]
	[Guid("00000550-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier]
	[ComImport]
	public interface _Connection : Connection15
	{
		// Token: 0x060002BF RID: 703
		void _VtblGap1_1();

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002C0 RID: 704
		// (set) Token: 0x060002C1 RID: 705
		[DispId(0)]
		[IndexerName("ConnectionString")]
		string ConnectionString { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x060002C2 RID: 706
		void _VtblGap2_5();

		// Token: 0x060002C3 RID: 707
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Close();

		// Token: 0x060002C4 RID: 708
		void _VtblGap3_4();

		// Token: 0x060002C5 RID: 709
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Open([MarshalAs(UnmanagedType.BStr)] [In] string ConnectionString = "", [MarshalAs(UnmanagedType.BStr)] [In] string UserID = "", [MarshalAs(UnmanagedType.BStr)] [In] string Password = "", [In] int Options = -1);
	}
}
