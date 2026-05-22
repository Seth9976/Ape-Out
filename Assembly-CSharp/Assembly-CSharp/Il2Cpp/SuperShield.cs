using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001BD RID: 445
	public class SuperShield : MonoBehaviour
	{
		// Token: 0x0600311A RID: 12570 RVA: 0x000BB7E8 File Offset: 0x000B99E8
		// Note: this type is marked as 'beforefieldinit'.
		static SuperShield()
		{
			Il2CppClassPointerStore<SuperShield>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SuperShield");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuperShield>.NativeClassPtr);
			SuperShield.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperShield>.NativeClassPtr, "health");
			SuperShield.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuperShield>.NativeClassPtr, 100667147);
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000BB840 File Offset: 0x000B9A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SuperShield()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuperShield>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuperShield.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x00021AEC File Offset: 0x0001FCEC
		public SuperShield(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x000BB87C File Offset: 0x000B9A7C
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x00021AF5 File Offset: 0x0001FCF5
		public unsafe int health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperShield.NativeFieldInfoPtr_health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperShield.NativeFieldInfoPtr_health)) = value;
			}
		}

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeFieldInfoPtr_health;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
