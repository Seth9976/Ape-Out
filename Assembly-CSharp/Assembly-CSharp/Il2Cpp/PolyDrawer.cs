using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000168 RID: 360
	public class PolyDrawer : MonoBehaviour
	{
		// Token: 0x06002B9F RID: 11167 RVA: 0x000ACECC File Offset: 0x000AB0CC
		// Note: this type is marked as 'beforefieldinit'.
		static PolyDrawer()
		{
			Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PolyDrawer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr);
			PolyDrawer.NativeFieldInfoPtr_poly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr, "poly");
			PolyDrawer.NativeFieldInfoPtr_msh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr, "msh");
			PolyDrawer.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr, "pos");
			PolyDrawer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr, 100666726);
			PolyDrawer.NativeMethodInfoPtr_MyUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr, 100666727);
			PolyDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr, 100666728);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000ACF74 File Offset: 0x000AB174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79516, XrefRangeEnd = 79522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyDrawer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x000ACFA8 File Offset: 0x000AB1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79522, XrefRangeEnd = 79555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyDrawer.NativeMethodInfoPtr_MyUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x000ACFDC File Offset: 0x000AB1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolyDrawer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolyDrawer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolyDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x0001E3FE File Offset: 0x0001C5FE
		public PolyDrawer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000AD018 File Offset: 0x000AB218
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x0001E407 File Offset: 0x0001C607
		public unsafe PolygonCollider2D poly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyDrawer.NativeFieldInfoPtr_poly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyDrawer.NativeFieldInfoPtr_poly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000AD048 File Offset: 0x000AB248
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x0001E426 File Offset: 0x0001C626
		public unsafe MeshFilter msh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyDrawer.NativeFieldInfoPtr_msh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyDrawer.NativeFieldInfoPtr_msh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x000AD078 File Offset: 0x000AB278
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x0001E445 File Offset: 0x0001C645
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyDrawer.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PolyDrawer.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeFieldInfoPtr_poly;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeFieldInfoPtr_msh;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_MyUpdate_Public_Void_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
