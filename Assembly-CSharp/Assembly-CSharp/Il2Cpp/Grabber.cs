using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000EA RID: 234
	public class Grabber : MonoBehaviour
	{
		// Token: 0x06001BD3 RID: 7123 RVA: 0x00082AD0 File Offset: 0x00080CD0
		// Note: this type is marked as 'beforefieldinit'.
		static Grabber()
		{
			Il2CppClassPointerStore<Grabber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Grabber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grabber>.NativeClassPtr);
			Grabber.NativeFieldInfoPtr_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grabber>.NativeClassPtr, "mass");
			Grabber.NativeFieldInfoPtr_grabbed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grabber>.NativeClassPtr, "grabbed");
			Grabber.NativeFieldInfoPtr_posA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grabber>.NativeClassPtr, "posA");
			Grabber.NativeFieldInfoPtr_posB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grabber>.NativeClassPtr, "posB");
			Grabber.NativeFieldInfoPtr_autoSpin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grabber>.NativeClassPtr, "autoSpin");
			Grabber.NativeFieldInfoPtr_grabCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grabber>.NativeClassPtr, "grabCol");
			Grabber.NativeFieldInfoPtr_wallCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grabber>.NativeClassPtr, "wallCollider");
			Grabber.NativeMethodInfoPtr_OnGrabbed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grabber>.NativeClassPtr, 100665570);
			Grabber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grabber>.NativeClassPtr, 100665571);
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00082BB4 File Offset: 0x00080DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62561, XrefRangeEnd = 62562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGrabbed(bool bah)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bah;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grabber.NativeMethodInfoPtr_OnGrabbed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00082BF4 File Offset: 0x00080DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grabber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grabber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grabber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x000139FF File Offset: 0x00011BFF
		public Grabber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x00082C30 File Offset: 0x00080E30
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x00013A08 File Offset: 0x00011C08
		public unsafe float mass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_mass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_mass)) = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x00082C58 File Offset: 0x00080E58
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x00013A23 File Offset: 0x00011C23
		public unsafe bool grabbed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_grabbed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_grabbed)) = value;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x00082C80 File Offset: 0x00080E80
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x00013A3E File Offset: 0x00011C3E
		public unsafe Vector2 posA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_posA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_posA)) = value;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x00082CA8 File Offset: 0x00080EA8
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x00013A59 File Offset: 0x00011C59
		public unsafe Vector2 posB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_posB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_posB)) = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00082CD0 File Offset: 0x00080ED0
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x00013A74 File Offset: 0x00011C74
		public unsafe bool autoSpin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_autoSpin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_autoSpin)) = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00082CF8 File Offset: 0x00080EF8
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x00013A8F File Offset: 0x00011C8F
		public unsafe int grabCol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_grabCol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_grabCol)) = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x00082D20 File Offset: 0x00080F20
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x00013AAA File Offset: 0x00011CAA
		public unsafe GameObject wallCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_wallCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grabber.NativeFieldInfoPtr_wallCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeFieldInfoPtr_mass;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeFieldInfoPtr_grabbed;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeFieldInfoPtr_posA;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeFieldInfoPtr_posB;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeFieldInfoPtr_autoSpin;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeFieldInfoPtr_grabCol;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeFieldInfoPtr_wallCollider;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_OnGrabbed_Public_Void_Boolean_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
