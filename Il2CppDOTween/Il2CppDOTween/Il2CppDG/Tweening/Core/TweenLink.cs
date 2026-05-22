using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x02000051 RID: 81
	public class TweenLink : global::Il2CppSystem.Object
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x0001C85C File Offset: 0x0001AA5C
		// Note: this type is marked as 'beforefieldinit'.
		static TweenLink()
		{
			Il2CppClassPointerStore<TweenLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "TweenLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenLink>.NativeClassPtr);
			TweenLink.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenLink>.NativeClassPtr, "target");
			TweenLink.NativeFieldInfoPtr_behaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenLink>.NativeClassPtr, "behaviour");
			TweenLink.NativeFieldInfoPtr_lastSeenActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenLink>.NativeClassPtr, "lastSeenActive");
			TweenLink.NativeMethodInfoPtr__ctor_Public_Void_GameObject_LinkBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenLink>.NativeClassPtr, 100664254);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001C8DC File Offset: 0x0001AADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124722, RefRangeEnd = 124724, XrefRangeStart = 124720, XrefRangeEnd = 124722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TweenLink(GameObject target, LinkBehaviour behaviour)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweenLink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenLink.NativeMethodInfoPtr__ctor_Public_Void_GameObject_LinkBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00003A4A File Offset: 0x00001C4A
		public TweenLink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0001C938 File Offset: 0x0001AB38
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00003A53 File Offset: 0x00001C53
		public unsafe GameObject target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenLink.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenLink.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0001C968 File Offset: 0x0001AB68
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00003A72 File Offset: 0x00001C72
		public unsafe LinkBehaviour behaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenLink.NativeFieldInfoPtr_behaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenLink.NativeFieldInfoPtr_behaviour)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0001C990 File Offset: 0x0001AB90
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00003A8D File Offset: 0x00001C8D
		public unsafe bool lastSeenActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenLink.NativeFieldInfoPtr_lastSeenActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweenLink.NativeFieldInfoPtr_lastSeenActive)) = value;
			}
		}

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_behaviour;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_lastSeenActive;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_LinkBehaviour_0;
	}
}
