using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public sealed class AvatarMask : Object
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0000A118 File Offset: 0x00008318
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarMask()
		{
			Il2CppClassPointerStore<AvatarMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AvatarMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMask>.NativeClassPtr);
			AvatarMask.NativeMethodInfoPtr_GetHumanoidBodyPartActive_Public_Boolean_AvatarMaskBodyPart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMask>.NativeClassPtr, 100663363);
			AvatarMask.NativeMethodInfoPtr_get_transformCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMask>.NativeClassPtr, 100663364);
			AvatarMask.NativeMethodInfoPtr_GetTransformPath_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMask>.NativeClassPtr, 100663365);
			AvatarMask.NativeMethodInfoPtr_GetTransformWeight_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMask>.NativeClassPtr, 100663366);
			AvatarMask.NativeMethodInfoPtr_GetTransformActive_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMask>.NativeClassPtr, 100663367);
			AvatarMask.Internal_CreateDelegateField = IL2CPP.ResolveICall<AvatarMask.Internal_CreateDelegate>("UnityEngine.AvatarMask::Internal_Create");
			AvatarMask.SetHumanoidBodyPartActiveDelegateField = IL2CPP.ResolveICall<AvatarMask.SetHumanoidBodyPartActiveDelegate>("UnityEngine.AvatarMask::SetHumanoidBodyPartActive");
			AvatarMask.set_transformCountDelegateField = IL2CPP.ResolveICall<AvatarMask.set_transformCountDelegate>("UnityEngine.AvatarMask::set_transformCount");
			AvatarMask.AddTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.AddTransformPathDelegate>("UnityEngine.AvatarMask::AddTransformPath");
			AvatarMask.RemoveTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.RemoveTransformPathDelegate>("UnityEngine.AvatarMask::RemoveTransformPath");
			AvatarMask.SetTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.SetTransformPathDelegate>("UnityEngine.AvatarMask::SetTransformPath");
			AvatarMask.SetTransformWeightDelegateField = IL2CPP.ResolveICall<AvatarMask.SetTransformWeightDelegate>("UnityEngine.AvatarMask::SetTransformWeight");
			AvatarMask.get_hasFeetIKDelegateField = IL2CPP.ResolveICall<AvatarMask.get_hasFeetIKDelegate>("UnityEngine.AvatarMask::get_hasFeetIK");
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000A224 File Offset: 0x00008424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483920, XrefRangeEnd = 483924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMask.NativeMethodInfoPtr_GetHumanoidBodyPartActive_Public_Boolean_AvatarMaskBodyPart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000A270 File Offset: 0x00008470
		// (set) Token: 0x06000287 RID: 647 RVA: 0x000039D1 File Offset: 0x00001BD1
		public unsafe int transformCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 483928, RefRangeEnd = 483929, XrefRangeStart = 483924, XrefRangeEnd = 483928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMask.NativeMethodInfoPtr_get_transformCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				AvatarMask.set_transformCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000A2AC File Offset: 0x000084AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 483933, RefRangeEnd = 483934, XrefRangeStart = 483929, XrefRangeEnd = 483933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTransformPath(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMask.NativeMethodInfoPtr_GetTransformPath_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483934, XrefRangeEnd = 483938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTransformWeight(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMask.NativeMethodInfoPtr_GetTransformWeight_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000A33C File Offset: 0x0000853C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 483940, RefRangeEnd = 483942, XrefRangeStart = 483938, XrefRangeEnd = 483940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTransformActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMask.NativeMethodInfoPtr_GetTransformActive_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000039A2 File Offset: 0x00001BA2
		public AvatarMask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000039AB File Offset: 0x00001BAB
		public static void Internal_Create(AvatarMask self)
		{
			AvatarMask.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000A388 File Offset: 0x00008588
		public int humanoidBodyPartCount
		{
			get
			{
				return 13;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000039BD File Offset: 0x00001BBD
		public void SetHumanoidBodyPartActive(AvatarMaskBodyPart index, bool value)
		{
			AvatarMask.SetHumanoidBodyPartActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, value);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000039E4 File Offset: 0x00001BE4
		public void AddTransformPath(Transform transform)
		{
			this.AddTransformPath(transform, true);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000039F0 File Offset: 0x00001BF0
		public void AddTransformPath(Transform transform, bool recursive)
		{
			AvatarMask.AddTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), recursive);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003A09 File Offset: 0x00001C09
		public void RemoveTransformPath(Transform transform)
		{
			this.RemoveTransformPath(transform, true);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003A15 File Offset: 0x00001C15
		public void RemoveTransformPath(Transform transform, bool recursive)
		{
			AvatarMask.RemoveTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), recursive);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003A2E File Offset: 0x00001C2E
		public void SetTransformPath(int index, string path)
		{
			AvatarMask.SetTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00003A47 File Offset: 0x00001C47
		public void SetTransformWeight(int index, float weight)
		{
			AvatarMask.SetTransformWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, weight);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003A5B File Offset: 0x00001C5B
		public void SetTransformActive(int index, bool value)
		{
			this.SetTransformWeight(index, value ? 1f : 0f);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00003A75 File Offset: 0x00001C75
		public bool hasFeetIK
		{
			get
			{
				return AvatarMask.get_hasFeetIKDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000A39C File Offset: 0x0000859C
		public void Copy(AvatarMask other)
		{
			for (AvatarMaskBodyPart avatarMaskBodyPart = AvatarMaskBodyPart.Root; avatarMaskBodyPart < AvatarMaskBodyPart.LastBodyPart; avatarMaskBodyPart++)
			{
				this.SetHumanoidBodyPartActive(avatarMaskBodyPart, other.GetHumanoidBodyPartActive(avatarMaskBodyPart));
			}
			this.transformCount = other.transformCount;
			for (int i = 0; i < other.transformCount; i++)
			{
				this.SetTransformPath(i, other.GetTransformPath(i));
				this.SetTransformActive(i, other.GetTransformActive(i));
			}
		}

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_GetHumanoidBodyPartActive_Public_Boolean_AvatarMaskBodyPart_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_transformCount_Public_get_Int32_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformPath_Public_String_Int32_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformWeight_Private_Single_Int32_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformActive_Public_Boolean_Int32_0;

		// Token: 0x0400018E RID: 398
		private static readonly AvatarMask.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x0400018F RID: 399
		private static readonly AvatarMask.SetHumanoidBodyPartActiveDelegate SetHumanoidBodyPartActiveDelegateField;

		// Token: 0x04000190 RID: 400
		private static readonly AvatarMask.set_transformCountDelegate set_transformCountDelegateField;

		// Token: 0x04000191 RID: 401
		private static readonly AvatarMask.AddTransformPathDelegate AddTransformPathDelegateField;

		// Token: 0x04000192 RID: 402
		private static readonly AvatarMask.RemoveTransformPathDelegate RemoveTransformPathDelegateField;

		// Token: 0x04000193 RID: 403
		private static readonly AvatarMask.SetTransformPathDelegate SetTransformPathDelegateField;

		// Token: 0x04000194 RID: 404
		private static readonly AvatarMask.SetTransformWeightDelegate SetTransformWeightDelegateField;

		// Token: 0x04000195 RID: 405
		private static readonly AvatarMask.get_hasFeetIKDelegate get_hasFeetIKDelegateField;

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x06000781 RID: 1921
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x06000783 RID: 1923
		private delegate void SetHumanoidBodyPartActiveDelegate(IntPtr @this, AvatarMaskBodyPart index, bool value);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x06000785 RID: 1925
		private delegate void set_transformCountDelegate(IntPtr @this, int value);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x06000787 RID: 1927
		private delegate void AddTransformPathDelegate(IntPtr @this, IntPtr transform, bool recursive);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x06000789 RID: 1929
		private delegate void RemoveTransformPathDelegate(IntPtr @this, IntPtr transform, bool recursive);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x0600078B RID: 1931
		private delegate void SetTransformPathDelegate(IntPtr @this, int index, IntPtr path);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x0600078D RID: 1933
		private delegate void SetTransformWeightDelegate(IntPtr @this, int index, float weight);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x0600078F RID: 1935
		private delegate bool get_hasFeetIKDelegate(IntPtr @this);
	}
}
