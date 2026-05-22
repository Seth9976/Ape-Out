using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000092B0 File Offset: 0x000074B0
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorOverrideController()
		{
			Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorOverrideController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr);
			AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, "OnOverrideControllerDirty");
			AnimatorOverrideController.NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663355);
			AnimatorOverrideController.Internal_CreateDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.Internal_CreateDelegate>("UnityEngine.AnimatorOverrideController::Internal_Create");
			AnimatorOverrideController.get_runtimeAnimatorControllerDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.get_runtimeAnimatorControllerDelegate>("UnityEngine.AnimatorOverrideController::get_runtimeAnimatorController");
			AnimatorOverrideController.set_runtimeAnimatorControllerDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.set_runtimeAnimatorControllerDelegate>("UnityEngine.AnimatorOverrideController::set_runtimeAnimatorController");
			AnimatorOverrideController.Internal_GetClipByNameDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.Internal_GetClipByNameDelegate>("UnityEngine.AnimatorOverrideController::Internal_GetClipByName");
			AnimatorOverrideController.Internal_SetClipByNameDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.Internal_SetClipByNameDelegate>("UnityEngine.AnimatorOverrideController::Internal_SetClipByName");
			AnimatorOverrideController.GetClipDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.GetClipDelegate>("UnityEngine.AnimatorOverrideController::GetClip");
			AnimatorOverrideController.SetClipDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.SetClipDelegate>("UnityEngine.AnimatorOverrideController::SetClip");
			AnimatorOverrideController.SendNotificationDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.SendNotificationDelegate>("UnityEngine.AnimatorOverrideController::SendNotification");
			AnimatorOverrideController.GetOriginalClipDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.GetOriginalClipDelegate>("UnityEngine.AnimatorOverrideController::GetOriginalClip");
			AnimatorOverrideController.GetOverrideClipDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.GetOverrideClipDelegate>("UnityEngine.AnimatorOverrideController::GetOverrideClip");
			AnimatorOverrideController.get_overridesCountDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.get_overridesCountDelegate>("UnityEngine.AnimatorOverrideController::get_overridesCount");
			AnimatorOverrideController.PerformOverrideClipListCleanupDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.PerformOverrideClipListCleanupDelegate>("UnityEngine.AnimatorOverrideController::PerformOverrideClipListCleanup");
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000093BC File Offset: 0x000075BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483910, XrefRangeEnd = 483911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00003463 File Offset: 0x00001663
		public AnimatorOverrideController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000093F4 File Offset: 0x000075F4
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000346C File Offset: 0x0000166C
		public unsafe AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatorOverrideController.OnOverrideControllerDirtyCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000348B File Offset: 0x0000168B
		public static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller)
		{
			AnimatorOverrideController.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.Il2CppObjectBaseToPtr(controller));
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00009424 File Offset: 0x00007624
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000034A3 File Offset: 0x000016A3
		public RuntimeAnimatorController runtimeAnimatorController
		{
			get
			{
				IntPtr intPtr = AnimatorOverrideController.get_runtimeAnimatorControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				AnimatorOverrideController.set_runtimeAnimatorControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		public AnimationClip this[string name]
		{
			get
			{
				return this.Internal_GetClipByName(name, true);
			}
			set
			{
				this.Internal_SetClipByName(name, value);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000946C File Offset: 0x0000766C
		public AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip)
		{
			IntPtr intPtr = AnimatorOverrideController.Internal_GetClipByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), returnEffectiveClip);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000034C7 File Offset: 0x000016C7
		public void Internal_SetClipByName(string name, AnimationClip clip)
		{
			AnimatorOverrideController.Internal_SetClipByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(clip));
		}

		// Token: 0x17000089 RID: 137
		public AnimationClip this[AnimationClip clip]
		{
			get
			{
				return this.GetClip(clip, true);
			}
			set
			{
				this.SetClip(clip, value, true);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000094BC File Offset: 0x000076BC
		public AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip)
		{
			IntPtr intPtr = AnimatorOverrideController.GetClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(originalClip), returnEffectiveClip);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000034F2 File Offset: 0x000016F2
		public void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify)
		{
			AnimatorOverrideController.SetClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(originalClip), IL2CPP.Il2CppObjectBaseToPtr(overrideClip), notify);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00003511 File Offset: 0x00001711
		public void SendNotification()
		{
			AnimatorOverrideController.SendNotificationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000094F0 File Offset: 0x000076F0
		public AnimationClip GetOriginalClip(int index)
		{
			IntPtr intPtr = AnimatorOverrideController.GetOriginalClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00009520 File Offset: 0x00007720
		public AnimationClip GetOverrideClip(AnimationClip originalClip)
		{
			IntPtr intPtr = AnimatorOverrideController.GetOverrideClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(originalClip));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00003523 File Offset: 0x00001723
		public int overridesCount
		{
			get
			{
				return AnimatorOverrideController.get_overridesCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00009554 File Offset: 0x00007754
		public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			bool flag = overrides == null;
			if (flag)
			{
				throw new ArgumentNullException("overrides");
			}
			int overridesCount = this.overridesCount;
			bool flag2 = overrides.Capacity < overridesCount;
			if (flag2)
			{
				overrides.Capacity = overridesCount;
			}
			overrides.Clear();
			for (int i = 0; i < overridesCount; i++)
			{
				AnimationClip originalClip = this.GetOriginalClip(i);
				overrides.Add(new KeyValuePair<AnimationClip, AnimationClip>(originalClip, this.GetOverrideClip(originalClip)));
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000095CC File Offset: 0x000077CC
		public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			bool flag = overrides == null;
			if (flag)
			{
				throw new ArgumentNullException("overrides");
			}
			for (int i = 0; i < overrides.Count; i++)
			{
				KeyValuePair<AnimationClip, AnimationClip> keyValuePair = overrides[i];
				AnimationClip key = keyValuePair.Key;
				keyValuePair = overrides[i];
				this.SetClip(key, keyValuePair.Value, false);
			}
			this.SendNotification();
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00003535 File Offset: 0x00001735
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00003542 File Offset: 0x00001742
		public Il2CppReferenceArray<AnimationClipPair> clips
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000354F File Offset: 0x0000174F
		public void PerformOverrideClipListCleanup()
		{
			AnimatorOverrideController.PerformOverrideClipListCleanupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_OnOverrideControllerDirty;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0;

		// Token: 0x04000141 RID: 321
		private static readonly AnimatorOverrideController.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x04000142 RID: 322
		private static readonly AnimatorOverrideController.get_runtimeAnimatorControllerDelegate get_runtimeAnimatorControllerDelegateField;

		// Token: 0x04000143 RID: 323
		private static readonly AnimatorOverrideController.set_runtimeAnimatorControllerDelegate set_runtimeAnimatorControllerDelegateField;

		// Token: 0x04000144 RID: 324
		private static readonly AnimatorOverrideController.Internal_GetClipByNameDelegate Internal_GetClipByNameDelegateField;

		// Token: 0x04000145 RID: 325
		private static readonly AnimatorOverrideController.Internal_SetClipByNameDelegate Internal_SetClipByNameDelegateField;

		// Token: 0x04000146 RID: 326
		private static readonly AnimatorOverrideController.GetClipDelegate GetClipDelegateField;

		// Token: 0x04000147 RID: 327
		private static readonly AnimatorOverrideController.SetClipDelegate SetClipDelegateField;

		// Token: 0x04000148 RID: 328
		private static readonly AnimatorOverrideController.SendNotificationDelegate SendNotificationDelegateField;

		// Token: 0x04000149 RID: 329
		private static readonly AnimatorOverrideController.GetOriginalClipDelegate GetOriginalClipDelegateField;

		// Token: 0x0400014A RID: 330
		private static readonly AnimatorOverrideController.GetOverrideClipDelegate GetOverrideClipDelegateField;

		// Token: 0x0400014B RID: 331
		private static readonly AnimatorOverrideController.get_overridesCountDelegate get_overridesCountDelegateField;

		// Token: 0x0400014C RID: 332
		private static readonly AnimatorOverrideController.PerformOverrideClipListCleanupDelegate PerformOverrideClipListCleanupDelegateField;

		// Token: 0x0200012E RID: 302
		public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
		{
			// Token: 0x0600074B RID: 1867 RVA: 0x0000F734 File Offset: 0x0000D934
			// Note: this type is marked as 'beforefieldinit'.
			static OnOverrideControllerDirtyCallback()
			{
				Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, "OnOverrideControllerDirtyCallback");
				AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr, 100663356);
				AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr, 100663357);
				AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr, 100663358);
				AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr, 100663359);
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnOverrideControllerDirtyCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x0000F804 File Offset: 0x0000DA04
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x0000F838 File Offset: 0x0000DA38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x0000F89C File Offset: 0x0000DA9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x000058F4 File Offset: 0x00003AF4
			public OnOverrideControllerDirtyCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x000058FD File Offset: 0x00003AFD
			public static implicit operator AnimatorOverrideController.OnOverrideControllerDirtyCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<AnimatorOverrideController.OnOverrideControllerDirtyCallback>(A_0);
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x00005905 File Offset: 0x00003B05
			public static AnimatorOverrideController.OnOverrideControllerDirtyCallback operator +(AnimatorOverrideController.OnOverrideControllerDirtyCallback A_0, AnimatorOverrideController.OnOverrideControllerDirtyCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AnimatorOverrideController.OnOverrideControllerDirtyCallback>();
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x00005913 File Offset: 0x00003B13
			public static AnimatorOverrideController.OnOverrideControllerDirtyCallback operator -(AnimatorOverrideController.OnOverrideControllerDirtyCallback A_0, AnimatorOverrideController.OnOverrideControllerDirtyCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AnimatorOverrideController.OnOverrideControllerDirtyCallback>();
				}
				return delegate2;
			}

			// Token: 0x04000435 RID: 1077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000436 RID: 1078
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04000437 RID: 1079
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04000438 RID: 1080
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x06000755 RID: 1877
		private delegate void Internal_CreateDelegate(IntPtr self, IntPtr controller);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x06000757 RID: 1879
		private delegate IntPtr get_runtimeAnimatorControllerDelegate(IntPtr @this);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x06000759 RID: 1881
		private delegate void set_runtimeAnimatorControllerDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x0600075B RID: 1883
		private delegate IntPtr Internal_GetClipByNameDelegate(IntPtr @this, IntPtr name, bool returnEffectiveClip);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x0600075D RID: 1885
		private delegate void Internal_SetClipByNameDelegate(IntPtr @this, IntPtr name, IntPtr clip);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x0600075F RID: 1887
		private delegate IntPtr GetClipDelegate(IntPtr @this, IntPtr originalClip, bool returnEffectiveClip);

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x06000761 RID: 1889
		private delegate void SetClipDelegate(IntPtr @this, IntPtr originalClip, IntPtr overrideClip, bool notify);

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x06000763 RID: 1891
		private delegate void SendNotificationDelegate(IntPtr @this);

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x06000765 RID: 1893
		private delegate IntPtr GetOriginalClipDelegate(IntPtr @this, int index);

		// Token: 0x02000138 RID: 312
		// (Invoke) Token: 0x06000767 RID: 1895
		private delegate IntPtr GetOverrideClipDelegate(IntPtr @this, IntPtr originalClip);

		// Token: 0x02000139 RID: 313
		// (Invoke) Token: 0x06000769 RID: 1897
		private delegate int get_overridesCountDelegate(IntPtr @this);

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x0600076B RID: 1899
		private delegate void PerformOverrideClipListCleanupDelegate(IntPtr @this);
	}
}
