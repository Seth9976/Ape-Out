using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000149 RID: 329
	[StructLayout(2)]
	public struct Variant
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x0008CDE0 File Offset: 0x0008AFE0
		// Note: this type is marked as 'beforefieldinit'.
		static Variant()
		{
			Il2CppClassPointerStore<Variant>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Variant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Variant>.NativeClassPtr);
			Variant.NativeFieldInfoPtr_vt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "vt");
			Variant.NativeFieldInfoPtr_wReserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved1");
			Variant.NativeFieldInfoPtr_wReserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved2");
			Variant.NativeFieldInfoPtr_wReserved3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved3");
			Variant.NativeFieldInfoPtr_llVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "llVal");
			Variant.NativeFieldInfoPtr_lVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "lVal");
			Variant.NativeFieldInfoPtr_bVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bVal");
			Variant.NativeFieldInfoPtr_iVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "iVal");
			Variant.NativeFieldInfoPtr_fltVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "fltVal");
			Variant.NativeFieldInfoPtr_dblVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "dblVal");
			Variant.NativeFieldInfoPtr_boolVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "boolVal");
			Variant.NativeFieldInfoPtr_bstrVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bstrVal");
			Variant.NativeFieldInfoPtr_cVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "cVal");
			Variant.NativeFieldInfoPtr_uiVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "uiVal");
			Variant.NativeFieldInfoPtr_ulVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "ulVal");
			Variant.NativeFieldInfoPtr_ullVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "ullVal");
			Variant.NativeFieldInfoPtr_intVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "intVal");
			Variant.NativeFieldInfoPtr_uintVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "uintVal");
			Variant.NativeFieldInfoPtr_pdispVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "pdispVal");
			Variant.NativeFieldInfoPtr_bRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bRecord");
			Variant.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variant>.NativeClassPtr, 100667258);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0008CFB4 File Offset: 0x0008B1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178846, XrefRangeEnd = 178853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variant.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00008110 File Offset: 0x00006310
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Variant>.NativeClassPtr, ref this));
		}

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeFieldInfoPtr_vt;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeFieldInfoPtr_wReserved1;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeFieldInfoPtr_wReserved2;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeFieldInfoPtr_wReserved3;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeFieldInfoPtr_llVal;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeFieldInfoPtr_lVal;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeFieldInfoPtr_bVal;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeFieldInfoPtr_iVal;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeFieldInfoPtr_fltVal;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeFieldInfoPtr_dblVal;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeFieldInfoPtr_boolVal;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeFieldInfoPtr_bstrVal;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeFieldInfoPtr_cVal;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr_uiVal;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr_ulVal;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeFieldInfoPtr_ullVal;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeFieldInfoPtr_intVal;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeFieldInfoPtr_uintVal;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeFieldInfoPtr_pdispVal;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeFieldInfoPtr_bRecord;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001571 RID: 5489
		[FieldOffset(0)]
		public short vt;

		// Token: 0x04001572 RID: 5490
		[FieldOffset(2)]
		public ushort wReserved1;

		// Token: 0x04001573 RID: 5491
		[FieldOffset(4)]
		public ushort wReserved2;

		// Token: 0x04001574 RID: 5492
		[FieldOffset(6)]
		public ushort wReserved3;

		// Token: 0x04001575 RID: 5493
		[FieldOffset(8)]
		public long llVal;

		// Token: 0x04001576 RID: 5494
		[FieldOffset(8)]
		public int lVal;

		// Token: 0x04001577 RID: 5495
		[FieldOffset(8)]
		public byte bVal;

		// Token: 0x04001578 RID: 5496
		[FieldOffset(8)]
		public short iVal;

		// Token: 0x04001579 RID: 5497
		[FieldOffset(8)]
		public float fltVal;

		// Token: 0x0400157A RID: 5498
		[FieldOffset(8)]
		public double dblVal;

		// Token: 0x0400157B RID: 5499
		[FieldOffset(8)]
		public short boolVal;

		// Token: 0x0400157C RID: 5500
		[FieldOffset(8)]
		public IntPtr bstrVal;

		// Token: 0x0400157D RID: 5501
		[FieldOffset(8)]
		public sbyte cVal;

		// Token: 0x0400157E RID: 5502
		[FieldOffset(8)]
		public ushort uiVal;

		// Token: 0x0400157F RID: 5503
		[FieldOffset(8)]
		public uint ulVal;

		// Token: 0x04001580 RID: 5504
		[FieldOffset(8)]
		public ulong ullVal;

		// Token: 0x04001581 RID: 5505
		[FieldOffset(8)]
		public int intVal;

		// Token: 0x04001582 RID: 5506
		[FieldOffset(8)]
		public uint uintVal;

		// Token: 0x04001583 RID: 5507
		[FieldOffset(8)]
		public IntPtr pdispVal;

		// Token: 0x04001584 RID: 5508
		[FieldOffset(8)]
		public BRECORD bRecord;
	}
}
