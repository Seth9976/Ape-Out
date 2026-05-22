using System;
using Il2CppDG.Tweening.Core;
using Il2CppDG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppDG.Tweening
{
	// Token: 0x02000014 RID: 20
	public sealed class Sequence : Tween
	{
		// Token: 0x060000DB RID: 219 RVA: 0x000095DC File Offset: 0x000077DC
		// Note: this type is marked as 'beforefieldinit'.
		static Sequence()
		{
			Il2CppClassPointerStore<Sequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "Sequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence>.NativeClassPtr);
			Sequence.NativeFieldInfoPtr_sequencedTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "sequencedTweens");
			Sequence.NativeFieldInfoPtr__sequencedObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "_sequencedObjs");
			Sequence.NativeFieldInfoPtr_lastTweenInsertTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "lastTweenInsertTime");
			Sequence.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663446);
			Sequence.NativeMethodInfoPtr_DoPrepend_Internal_Static_Sequence_Sequence_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663447);
			Sequence.NativeMethodInfoPtr_DoInsert_Internal_Static_Sequence_Sequence_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663448);
			Sequence.NativeMethodInfoPtr_DoAppendInterval_Internal_Static_Sequence_Sequence_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663449);
			Sequence.NativeMethodInfoPtr_DoPrependInterval_Internal_Static_Sequence_Sequence_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663450);
			Sequence.NativeMethodInfoPtr_DoInsertCallback_Internal_Static_Sequence_Sequence_TweenCallback_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663451);
			Sequence.NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663452);
			Sequence.NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663453);
			Sequence.NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663454);
			Sequence.NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663455);
			Sequence.NativeMethodInfoPtr_Setup_Internal_Static_Void_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663456);
			Sequence.NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663457);
			Sequence.NativeMethodInfoPtr_DoApplyTween_Internal_Static_Boolean_Sequence_Single_Int32_Int32_Boolean_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663458);
			Sequence.NativeMethodInfoPtr_ApplyInternalCycle_Private_Static_Boolean_Sequence_Single_Single_UpdateMode_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663459);
			Sequence.NativeMethodInfoPtr_StableSortSequencedObjs_Private_Static_Void_List_1_ABSSequentiable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663460);
			Sequence.NativeMethodInfoPtr_IsAnyCallbackSet_Private_Static_Boolean_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663461);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00009788 File Offset: 0x00007988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119303, XrefRangeEnd = 119315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000097C4 File Offset: 0x000079C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119315, XrefRangeEnd = 119320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DoPrepend(Sequence inSequence, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoPrepend_Internal_Static_Sequence_Sequence_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000981C File Offset: 0x00007A1C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 119334, RefRangeEnd = 119356, XrefRangeStart = 119320, XrefRangeEnd = 119334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoInsert_Internal_Static_Sequence_Sequence_Tween_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00009880 File Offset: 0x00007A80
		[CallerCount(0)]
		public unsafe static Sequence DoAppendInterval(Sequence inSequence, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoAppendInterval_Internal_Static_Sequence_Sequence_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000098D4 File Offset: 0x00007AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119356, XrefRangeEnd = 119358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DoPrependInterval(Sequence inSequence, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoPrependInterval_Internal_Static_Sequence_Sequence_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00009928 File Offset: 0x00007B28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119364, RefRangeEnd = 119367, XrefRangeStart = 119358, XrefRangeEnd = 119364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoInsertCallback_Internal_Static_Sequence_Sequence_TweenCallback_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000998C File Offset: 0x00007B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119367, XrefRangeEnd = 119372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000099C0 File Offset: 0x00007BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119372, XrefRangeEnd = 119374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000099FC File Offset: 0x00007BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119374, XrefRangeEnd = 119375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Startup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00009A38 File Offset: 0x00007C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119375, XrefRangeEnd = 119376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref prevPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevCompletedLoops;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCompletedSteps;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInversePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119376, XrefRangeEnd = 119390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Setup(Sequence s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_Setup_Internal_Static_Void_Sequence_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00009B00 File Offset: 0x00007D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119393, RefRangeEnd = 119394, XrefRangeStart = 119390, XrefRangeEnd = 119393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoStartup(Sequence s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_Sequence_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00009B44 File Offset: 0x00007D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119405, RefRangeEnd = 119406, XrefRangeStart = 119394, XrefRangeEnd = 119405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevCompletedLoops;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCompletedSteps;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInversePosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoApplyTween_Internal_Static_Boolean_Sequence_Single_Int32_Int32_Boolean_UpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00009BCC File Offset: 0x00007DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119471, RefRangeEnd = 119472, XrefRangeStart = 119406, XrefRangeEnd = 119471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInverse;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevPosIsInverse;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiCycleStep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_ApplyInternalCycle_Private_Static_Boolean_Sequence_Single_Single_UpdateMode_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00009C64 File Offset: 0x00007E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119472, XrefRangeEnd = 119477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StableSortSequencedObjs(List<ABSSequentiable> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_StableSortSequencedObjs_Private_Static_Void_List_1_ABSSequentiable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00009C9C File Offset: 0x00007E9C
		[CallerCount(0)]
		public unsafe static bool IsAnyCallbackSet(Sequence s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_IsAnyCallbackSet_Private_Static_Boolean_Sequence_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000022D3 File Offset: 0x000004D3
		public Sequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00009CE0 File Offset: 0x00007EE0
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000022DC File Offset: 0x000004DC
		public unsafe List<Tween> sequencedTweens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr_sequencedTweens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr_sequencedTweens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00009D10 File Offset: 0x00007F10
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000022FB File Offset: 0x000004FB
		public unsafe List<ABSSequentiable> _sequencedObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr__sequencedObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ABSSequentiable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr__sequencedObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00009D40 File Offset: 0x00007F40
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000231A File Offset: 0x0000051A
		public unsafe float lastTweenInsertTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr_lastTweenInsertTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr_lastTweenInsertTime)) = value;
			}
		}

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_sequencedTweens;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr__sequencedObjs;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_lastTweenInsertTime;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_DoPrepend_Internal_Static_Sequence_Sequence_Tween_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_DoInsert_Internal_Static_Sequence_Sequence_Tween_Single_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_DoAppendInterval_Internal_Static_Sequence_Sequence_Single_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_DoPrependInterval_Internal_Static_Sequence_Sequence_Single_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_DoInsertCallback_Internal_Static_Sequence_Sequence_TweenCallback_Single_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Static_Void_Sequence_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_Sequence_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_DoApplyTween_Internal_Static_Boolean_Sequence_Single_Int32_Int32_Boolean_UpdateMode_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInternalCycle_Private_Static_Boolean_Sequence_Single_Single_UpdateMode_Boolean_Boolean_Boolean_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_StableSortSequencedObjs_Private_Static_Void_List_1_ABSSequentiable_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyCallbackSet_Private_Static_Boolean_Sequence_0;
	}
}
