using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000167 RID: 359
	public class PoleWire : MonoBehaviour
	{
		// Token: 0x06002B94 RID: 11156 RVA: 0x000ACCF0 File Offset: 0x000AAEF0
		// Note: this type is marked as 'beforefieldinit'.
		static PoleWire()
		{
			Il2CppClassPointerStore<PoleWire>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PoleWire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoleWire>.NativeClassPtr);
			PoleWire.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoleWire>.NativeClassPtr, "a");
			PoleWire.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoleWire>.NativeClassPtr, "b");
			PoleWire.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoleWire>.NativeClassPtr, "line");
			PoleWire.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoleWire>.NativeClassPtr, 100666723);
			PoleWire.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoleWire>.NativeClassPtr, 100666724);
			PoleWire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoleWire>.NativeClassPtr, 100666725);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x000ACD98 File Offset: 0x000AAF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79501, XrefRangeEnd = 79504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoleWire.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x000ACDCC File Offset: 0x000AAFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79504, XrefRangeEnd = 79516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoleWire.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x000ACE00 File Offset: 0x000AB000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoleWire()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoleWire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoleWire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0001E398 File Offset: 0x0001C598
		public PoleWire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x000ACE3C File Offset: 0x000AB03C
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x0001E3A1 File Offset: 0x0001C5A1
		public unsafe GameObject a
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoleWire.NativeFieldInfoPtr_a);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoleWire.NativeFieldInfoPtr_a), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000ACE6C File Offset: 0x000AB06C
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		public unsafe GameObject b
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoleWire.NativeFieldInfoPtr_b);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoleWire.NativeFieldInfoPtr_b), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x000ACE9C File Offset: 0x000AB09C
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x0001E3DF File Offset: 0x0001C5DF
		public unsafe LineRenderer line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoleWire.NativeFieldInfoPtr_line);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoleWire.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
