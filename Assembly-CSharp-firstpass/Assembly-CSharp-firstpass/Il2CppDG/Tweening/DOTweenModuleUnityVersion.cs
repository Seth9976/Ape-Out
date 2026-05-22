using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Plugins.Options;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening
{
	// Token: 0x020001F2 RID: 498
	public static class DOTweenModuleUnityVersion : global::Il2CppSystem.Object
	{
		// Token: 0x06001984 RID: 6532 RVA: 0x000739E8 File Offset: 0x00071BE8
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenModuleUnityVersion()
		{
			Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "DG.Tweening", "DOTweenModuleUnityVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Material_Gradient_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667292);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Material_Gradient_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667293);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForCompletion_Public_Static_CustomYieldInstruction_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667294);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForRewind_Public_Static_CustomYieldInstruction_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667295);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForKill_Public_Static_CustomYieldInstruction_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667296);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_CustomYieldInstruction_Tween_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667297);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForPosition_Public_Static_CustomYieldInstruction_Tween_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667298);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForStart_Public_Static_CustomYieldInstruction_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667299);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667300);
			DOTweenModuleUnityVersion.NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, 100667301);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00073AE0 File Offset: 0x00071CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22562, XrefRangeEnd = 22582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gradient);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Material_Gradient_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00073B44 File Offset: 0x00071D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22582, XrefRangeEnd = 22602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gradient);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(property);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Material_Gradient_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00073BBC File Offset: 0x00071DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22602, XrefRangeEnd = 22606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnCustomYieldInstruction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForCompletion_Public_Static_CustomYieldInstruction_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomYieldInstruction>(intPtr3) : null;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00073C10 File Offset: 0x00071E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22606, XrefRangeEnd = 22610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnCustomYieldInstruction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForRewind_Public_Static_CustomYieldInstruction_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomYieldInstruction>(intPtr3) : null;
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00073C64 File Offset: 0x00071E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22610, XrefRangeEnd = 22614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnCustomYieldInstruction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForKill_Public_Static_CustomYieldInstruction_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomYieldInstruction>(intPtr3) : null;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00073CB8 File Offset: 0x00071EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22614, XrefRangeEnd = 22618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedLoops;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnCustomYieldInstruction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_CustomYieldInstruction_Tween_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomYieldInstruction>(intPtr3) : null;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00073D18 File Offset: 0x00071F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22618, XrefRangeEnd = 22622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnCustomYieldInstruction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForPosition_Public_Static_CustomYieldInstruction_Tween_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomYieldInstruction>(intPtr3) : null;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00073D78 File Offset: 0x00071F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22622, XrefRangeEnd = 22626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnCustomYieldInstruction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_WaitForStart_Public_Static_CustomYieldInstruction_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomYieldInstruction>(intPtr3) : null;
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00073DCC File Offset: 0x00071FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22626, XrefRangeEnd = 22650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00073E3C File Offset: 0x0007203C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22650, XrefRangeEnd = 22674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propertyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<Vector2, Vector2, VectorOptions>>(intPtr3) : null;
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00009F19 File Offset: 0x00008119
		public DOTweenModuleUnityVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Material_Gradient_Single_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_DOGradientColor_Public_Static_Sequence_Material_Gradient_String_Single_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Static_CustomYieldInstruction_Tween_Boolean_0;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeMethodInfoPtr_WaitForRewind_Public_Static_CustomYieldInstruction_Tween_Boolean_0;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeMethodInfoPtr_WaitForKill_Public_Static_CustomYieldInstruction_Tween_Boolean_0;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_CustomYieldInstruction_Tween_Int32_Boolean_0;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_WaitForPosition_Public_Static_CustomYieldInstruction_Tween_Single_Boolean_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_WaitForStart_Public_Static_CustomYieldInstruction_Tween_Boolean_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_DOOffset_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Int32_Single_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_DOTiling_Public_Static_TweenerCore_3_Vector2_Vector2_VectorOptions_Material_Vector2_Int32_Single_0;

		// Token: 0x020002AF RID: 687
		[ObfuscatedName("DG.Tweening.DOTweenModuleUnityVersion+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060023FA RID: 9210 RVA: 0x00099BB4 File Offset: 0x00097DB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass8_0>.NativeClassPtr);
				DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass8_0>.NativeClassPtr, "target");
				DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeFieldInfoPtr_propertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass8_0>.NativeClassPtr, "propertyID");
				DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass8_0>.NativeClassPtr, 100667302);
				DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass8_0>.NativeClassPtr, 100667303);
				DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass8_0>.NativeClassPtr, 100667304);
			}

			// Token: 0x060023FB RID: 9211 RVA: 0x00099C44 File Offset: 0x00097E44
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023FC RID: 9212 RVA: 0x00099C80 File Offset: 0x00097E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22554, XrefRangeEnd = 22556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOOffset_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023FD RID: 9213 RVA: 0x00099CBC File Offset: 0x00097EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22556, XrefRangeEnd = 22558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOOffset_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023FE RID: 9214 RVA: 0x0000D7E1 File Offset: 0x0000B9E1
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x060023FF RID: 9215 RVA: 0x00099CFC File Offset: 0x00097EFC
			// (set) Token: 0x06002400 RID: 9216 RVA: 0x0000D7EA File Offset: 0x0000B9EA
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06002401 RID: 9217 RVA: 0x00099D2C File Offset: 0x00097F2C
			// (set) Token: 0x06002402 RID: 9218 RVA: 0x0000D809 File Offset: 0x0000BA09
			public unsafe int propertyID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeFieldInfoPtr_propertyID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUnityVersion.__c__DisplayClass8_0.NativeFieldInfoPtr_propertyID)) = value;
				}
			}

			// Token: 0x04002266 RID: 8806
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04002267 RID: 8807
			private static readonly IntPtr NativeFieldInfoPtr_propertyID;

			// Token: 0x04002268 RID: 8808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002269 RID: 8809
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__0_Internal_Vector2_0;

			// Token: 0x0400226A RID: 8810
			private static readonly IntPtr NativeMethodInfoPtr__DOOffset_b__1_Internal_Void_Vector2_0;
		}

		// Token: 0x020002B0 RID: 688
		[ObfuscatedName("DG.Tweening.DOTweenModuleUnityVersion+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002403 RID: 9219 RVA: 0x00099D54 File Offset: 0x00097F54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenModuleUnityVersion>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass9_0>.NativeClassPtr);
				DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass9_0>.NativeClassPtr, "target");
				DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeFieldInfoPtr_propertyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass9_0>.NativeClassPtr, "propertyID");
				DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass9_0>.NativeClassPtr, 100667305);
				DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass9_0>.NativeClassPtr, 100667306);
				DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass9_0>.NativeClassPtr, 100667307);
			}

			// Token: 0x06002404 RID: 9220 RVA: 0x00099DE4 File Offset: 0x00097FE4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenModuleUnityVersion.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002405 RID: 9221 RVA: 0x00099E20 File Offset: 0x00098020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22558, XrefRangeEnd = 22560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DOTiling_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002406 RID: 9222 RVA: 0x00099E5C File Offset: 0x0009805C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22560, XrefRangeEnd = 22562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DOTiling_b__1(Vector2 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002407 RID: 9223 RVA: 0x0000D824 File Offset: 0x0000BA24
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x06002408 RID: 9224 RVA: 0x00099E9C File Offset: 0x0009809C
			// (set) Token: 0x06002409 RID: 9225 RVA: 0x0000D82D File Offset: 0x0000BA2D
			public unsafe Material target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x0600240A RID: 9226 RVA: 0x00099ECC File Offset: 0x000980CC
			// (set) Token: 0x0600240B RID: 9227 RVA: 0x0000D84C File Offset: 0x0000BA4C
			public unsafe int propertyID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeFieldInfoPtr_propertyID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenModuleUnityVersion.__c__DisplayClass9_0.NativeFieldInfoPtr_propertyID)) = value;
				}
			}

			// Token: 0x0400226B RID: 8811
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400226C RID: 8812
			private static readonly IntPtr NativeFieldInfoPtr_propertyID;

			// Token: 0x0400226D RID: 8813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400226E RID: 8814
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__0_Internal_Vector2_0;

			// Token: 0x0400226F RID: 8815
			private static readonly IntPtr NativeMethodInfoPtr__DOTiling_b__1_Internal_Void_Vector2_0;
		}
	}
}
