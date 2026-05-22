using System;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x0200004F RID: 79
	public static class DOTweenExternalCommand : global::Il2CppSystem.Object
	{
		// Token: 0x060004E1 RID: 1249 RVA: 0x0001C678 File Offset: 0x0001A878
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenExternalCommand()
		{
			Il2CppClassPointerStore<DOTweenExternalCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "DOTweenExternalCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenExternalCommand>.NativeClassPtr);
			DOTweenExternalCommand.NativeFieldInfoPtr_SetOrientationOnPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenExternalCommand>.NativeClassPtr, "SetOrientationOnPath");
			DOTweenExternalCommand.NativeMethodInfoPtr_add_SetOrientationOnPath_Public_Static_add_Void_Action_4_PathOptions_Tween_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenExternalCommand>.NativeClassPtr, 100664250);
			DOTweenExternalCommand.NativeMethodInfoPtr_remove_SetOrientationOnPath_Public_Static_rem_Void_Action_4_PathOptions_Tween_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenExternalCommand>.NativeClassPtr, 100664251);
			DOTweenExternalCommand.NativeMethodInfoPtr_Dispatch_SetOrientationOnPath_Internal_Static_Void_PathOptions_Tween_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenExternalCommand>.NativeClassPtr, 100664252);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124703, XrefRangeEnd = 124709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_SetOrientationOnPath(Action<PathOptions, Tween, Quaternion, Transform> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenExternalCommand.NativeMethodInfoPtr_add_SetOrientationOnPath_Public_Static_add_Void_Action_4_PathOptions_Tween_Quaternion_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001C730 File Offset: 0x0001A930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124709, XrefRangeEnd = 124715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_SetOrientationOnPath(Action<PathOptions, Tween, Quaternion, Transform> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenExternalCommand.NativeMethodInfoPtr_remove_SetOrientationOnPath_Public_Static_rem_Void_Action_4_PathOptions_Tween_Quaternion_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001C768 File Offset: 0x0001A968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124715, XrefRangeEnd = 124720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispatch_SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(options));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trans);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenExternalCommand.NativeMethodInfoPtr_Dispatch_SetOrientationOnPath_Internal_Static_Void_PathOptions_Tween_Quaternion_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000039ED File Offset: 0x00001BED
		public DOTweenExternalCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x000039F6 File Offset: 0x00001BF6
		public unsafe static Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTweenExternalCommand.NativeFieldInfoPtr_SetOrientationOnPath, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PathOptions, Tween, Quaternion, Transform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTweenExternalCommand.NativeFieldInfoPtr_SetOrientationOnPath, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_SetOrientationOnPath;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_add_SetOrientationOnPath_Public_Static_add_Void_Action_4_PathOptions_Tween_Quaternion_Transform_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_remove_SetOrientationOnPath_Public_Static_rem_Void_Action_4_PathOptions_Tween_Quaternion_Transform_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_SetOrientationOnPath_Internal_Static_Void_PathOptions_Tween_Quaternion_Transform_0;
	}
}
