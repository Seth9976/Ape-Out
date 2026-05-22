using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Core.PathCore;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x020001F4 RID: 500
	public static class DOTweenModuleUtils : global::Il2CppSystem.Object
	{
		// Token: 0x06001992 RID: 6546 RVA: 0x00073EAC File Offset: 0x000720AC
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenModuleUtils()
		{
			Il2CppClassPointerStore<DOTweenModuleUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DG.Tweening", "DOTweenModuleUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUtils>.NativeClassPtr);
			DOTweenModuleUtils.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUtils>.NativeClassPtr, "_initialized");
			DOTweenModuleUtils.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUtils>.NativeClassPtr, 100667320);
			DOTweenModuleUtils.NativeMethodInfoPtr_Preserver_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUtils>.NativeClassPtr, 100667321);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00073F18 File Offset: 0x00072118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22726, XrefRangeEnd = 22740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUtils.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00073F40 File Offset: 0x00072140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22740, XrefRangeEnd = 22753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Preserver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUtils.NativeMethodInfoPtr_Preserver_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00009F50 File Offset: 0x00008150
		public DOTweenModuleUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x00073F68 File Offset: 0x00072168
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x00009F59 File Offset: 0x00008159
		public unsafe static bool _initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DOTweenModuleUtils.NativeFieldInfoPtr__initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTweenModuleUtils.NativeFieldInfoPtr__initialized, (void*)(&value));
			}
		}

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeFieldInfoPtr__initialized;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_Preserver_Private_Static_Void_0;

		// Token: 0x020002B7 RID: 695
		public static class Physics : global::Il2CppSystem.Object
		{
			// Token: 0x06002434 RID: 9268 RVA: 0x0009A694 File Offset: 0x00098894
			// Note: this type is marked as 'beforefieldinit'.
			static Physics()
			{
				Il2CppClassPointerStore<DOTweenModuleUtils.Physics>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUtils>.NativeClassPtr, "Physics");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUtils.Physics>.NativeClassPtr);
				DOTweenModuleUtils.Physics.NativeMethodInfoPtr_SetOrientationOnPath_Public_Static_Void_PathOptions_Tween_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUtils.Physics>.NativeClassPtr, 100667322);
				DOTweenModuleUtils.Physics.NativeMethodInfoPtr_HasRigidbody2D_Public_Static_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUtils.Physics>.NativeClassPtr, 100667323);
				DOTweenModuleUtils.Physics.NativeMethodInfoPtr_HasRigidbody_Public_Static_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUtils.Physics>.NativeClassPtr, 100667324);
				DOTweenModuleUtils.Physics.NativeMethodInfoPtr_CreateDOTweenPathTween_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_MonoBehaviour_Boolean_Boolean_Path_Single_PathMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUtils.Physics>.NativeClassPtr, 100667325);
			}

			// Token: 0x06002435 RID: 9269 RVA: 0x0009A710 File Offset: 0x00098910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22677, XrefRangeEnd = 22680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUtils.Physics.NativeMethodInfoPtr_SetOrientationOnPath_Public_Static_Void_PathOptions_Tween_Quaternion_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002436 RID: 9270 RVA: 0x0009A780 File Offset: 0x00098980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22680, XrefRangeEnd = 22695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool HasRigidbody2D(Component target)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUtils.Physics.NativeMethodInfoPtr_HasRigidbody2D_Public_Static_Boolean_Component_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002437 RID: 9271 RVA: 0x0009A7C4 File Offset: 0x000989C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22695, XrefRangeEnd = 22710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool HasRigidbody(Component target)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUtils.Physics.NativeMethodInfoPtr_HasRigidbody_Public_Static_Boolean_Component_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002438 RID: 9272 RVA: 0x0009A808 File Offset: 0x00098A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22710, XrefRangeEnd = 22726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tweenRigidbody;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocal;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUtils.Physics.NativeMethodInfoPtr_CreateDOTweenPathTween_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_MonoBehaviour_Boolean_Boolean_Path_Single_PathMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector3, Path, PathOptions>>(intPtr3) : null;
			}

			// Token: 0x06002439 RID: 9273 RVA: 0x0000D98D File Offset: 0x0000BB8D
			public Physics(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002284 RID: 8836
			private static readonly IntPtr NativeMethodInfoPtr_SetOrientationOnPath_Public_Static_Void_PathOptions_Tween_Quaternion_Transform_0;

			// Token: 0x04002285 RID: 8837
			private static readonly IntPtr NativeMethodInfoPtr_HasRigidbody2D_Public_Static_Boolean_Component_0;

			// Token: 0x04002286 RID: 8838
			private static readonly IntPtr NativeMethodInfoPtr_HasRigidbody_Public_Static_Boolean_Component_0;

			// Token: 0x04002287 RID: 8839
			private static readonly IntPtr NativeMethodInfoPtr_CreateDOTweenPathTween_Public_Static_TweenerCore_3_Vector3_Path_PathOptions_MonoBehaviour_Boolean_Boolean_Path_Single_PathMode_0;
		}
	}
}
