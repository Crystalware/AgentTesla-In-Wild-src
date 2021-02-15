using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000031 RID: 49
	[CompilerGenerated]
	[DefaultMember("Fields")]
	[Guid("00000556-0000-0010-8000-00AA006D2EA4")]
	[TypeIdentifier]
	[ComImport]
	public interface _Recordset : Recordset21
	{
		// Token: 0x060002C6 RID: 710
		void _VtblGap1_6();

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002C7 RID: 711
		[DispId(1002)]
		bool BOF { [DispId(1002)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060002C8 RID: 712
		void _VtblGap2_6();

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002C9 RID: 713
		[DispId(1006)]
		bool EOF { [DispId(1006)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002CA RID: 714
		[DispId(0)]
		[IndexerName("Fields")]
		Fields Fields { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060002CB RID: 715
		void _VtblGap3_8();

		// Token: 0x060002CC RID: 716
		[DispId(1012)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void AddNew([MarshalAs(UnmanagedType.Struct)] [In] [Optional] object FieldList, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object Values);

		// Token: 0x060002CD RID: 717
		void _VtblGap4_1();

		// Token: 0x060002CE RID: 718
		[DispId(1014)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Close();

		// Token: 0x060002CF RID: 719
		[DispId(1015)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Delete([In] AffectEnum AffectRecords = AffectEnum.adAffectCurrent);

		// Token: 0x060002D0 RID: 720
		void _VtblGap5_2();

		// Token: 0x060002D1 RID: 721
		[DispId(1018)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MoveNext();

		// Token: 0x060002D2 RID: 722
		[DispId(1019)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MovePrevious();

		// Token: 0x060002D3 RID: 723
		[DispId(1020)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MoveFirst();

		// Token: 0x060002D4 RID: 724
		[DispId(1021)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void MoveLast();

		// Token: 0x060002D5 RID: 725
		[DispId(1022)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Open([MarshalAs(UnmanagedType.Struct)] [In] [Optional] object Source, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object ActiveConnection, [In] CursorTypeEnum CursorType = CursorTypeEnum.adOpenUnspecified, [In] LockTypeEnum LockType = LockTypeEnum.adLockUnspecified, [In] int Options = -1);

		// Token: 0x060002D6 RID: 726
		void _VtblGap6_2();

		// Token: 0x060002D7 RID: 727
		[DispId(1025)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Update([MarshalAs(UnmanagedType.Struct)] [In] [Optional] object Fields, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object Values);
	}
}
