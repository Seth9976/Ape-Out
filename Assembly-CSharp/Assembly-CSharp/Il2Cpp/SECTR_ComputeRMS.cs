using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003E RID: 62
	public class SECTR_ComputeRMS : MonoBehaviour
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x000520DC File Offset: 0x000502DC
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_ComputeRMS()
		{
			Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_ComputeRMS");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr);
			SECTR_ComputeRMS.NativeFieldInfoPtr_hdrBakeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, "hdrBakeList");
			SECTR_ComputeRMS.NativeFieldInfoPtr_activeBakeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, "activeBakeList");
			SECTR_ComputeRMS.NativeFieldInfoPtr_hdrBakeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, "hdrBakeIndex");
			SECTR_ComputeRMS.NativeFieldInfoPtr_cue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, "cue");
			SECTR_ComputeRMS.NativeFieldInfoPtr_clipData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, "clipData");
			SECTR_ComputeRMS.NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, "samples");
			SECTR_ComputeRMS.NativeFieldInfoPtr_numChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, "numChannels");
			SECTR_ComputeRMS.NativeMethodInfoPtr_get_Progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, 100664129);
			SECTR_ComputeRMS.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, 100664130);
			SECTR_ComputeRMS.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, 100664131);
			SECTR_ComputeRMS.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, 100664132);
			SECTR_ComputeRMS.NativeMethodInfoPtr_OnAudioFilterRead_Private_Void_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, 100664133);
			SECTR_ComputeRMS.NativeMethodInfoPtr__StartCompute_Public_Void_SECTR_AudioCue_ClipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, 100664134);
			SECTR_ComputeRMS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, 100664135);
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00052224 File Offset: 0x00050424
		public unsafe float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39666, XrefRangeEnd = 39676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ComputeRMS.NativeMethodInfoPtr_get_Progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00052260 File Offset: 0x00050460
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ComputeRMS.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00052294 File Offset: 0x00050494
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ComputeRMS.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000522C8 File Offset: 0x000504C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39676, XrefRangeEnd = 39756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ComputeRMS.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000522FC File Offset: 0x000504FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39756, XrefRangeEnd = 39759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAudioFilterRead(Il2CppStructArray<float> samples, int numChannels)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(samples);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numChannels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ComputeRMS.NativeMethodInfoPtr_OnAudioFilterRead_Private_Void_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0005234C File Offset: 0x0005054C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39819, RefRangeEnd = 39820, XrefRangeStart = 39759, XrefRangeEnd = 39819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _StartCompute(SECTR_AudioCue cue, SECTR_AudioCue.ClipData clipData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clipData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ComputeRMS.NativeMethodInfoPtr__StartCompute_Public_Void_SECTR_AudioCue_ClipData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000523A0 File Offset: 0x000505A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39820, XrefRangeEnd = 39834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_ComputeRMS()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ComputeRMS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00008647 File Offset: 0x00006847
		public SECTR_ComputeRMS(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000523DC File Offset: 0x000505DC
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00008650 File Offset: 0x00006850
		public unsafe List<SECTR_ComputeRMS.BakeInfo> hdrBakeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_hdrBakeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_ComputeRMS.BakeInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_hdrBakeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0005240C File Offset: 0x0005060C
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0000866F File Offset: 0x0000686F
		public unsafe List<SECTR_ComputeRMS> activeBakeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_activeBakeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_ComputeRMS>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_activeBakeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0005243C File Offset: 0x0005063C
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x0000868E File Offset: 0x0000688E
		public unsafe int hdrBakeIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_hdrBakeIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_hdrBakeIndex)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00052464 File Offset: 0x00050664
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x000086A9 File Offset: 0x000068A9
		public unsafe SECTR_AudioCue cue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_cue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_cue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00052494 File Offset: 0x00050694
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x000086C8 File Offset: 0x000068C8
		public unsafe SECTR_AudioCue.ClipData clipData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_clipData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue.ClipData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_clipData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000524C4 File Offset: 0x000506C4
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x000086E7 File Offset: 0x000068E7
		public unsafe List<float> samples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_samples);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_samples), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x000524F4 File Offset: 0x000506F4
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00008706 File Offset: 0x00006906
		public unsafe int numChannels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_numChannels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.NativeFieldInfoPtr_numChannels)) = value;
			}
		}

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_hdrBakeList;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_activeBakeList;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_hdrBakeIndex;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_cue;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_clipData;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_samples;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr_numChannels;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Public_get_Single_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_OnAudioFilterRead_Private_Void_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr__StartCompute_Public_Void_SECTR_AudioCue_ClipData_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002B8 RID: 696
		public sealed class BakeInfo : ValueType
		{
			// Token: 0x06004B7A RID: 19322 RVA: 0x001171EC File Offset: 0x001153EC
			// Note: this type is marked as 'beforefieldinit'.
			static BakeInfo()
			{
				Il2CppClassPointerStore<SECTR_ComputeRMS.BakeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_ComputeRMS>.NativeClassPtr, "BakeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_ComputeRMS.BakeInfo>.NativeClassPtr);
				SECTR_ComputeRMS.BakeInfo.NativeFieldInfoPtr_cue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS.BakeInfo>.NativeClassPtr, "cue");
				SECTR_ComputeRMS.BakeInfo.NativeFieldInfoPtr_clipData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_ComputeRMS.BakeInfo>.NativeClassPtr, "clipData");
				SECTR_ComputeRMS.BakeInfo.NativeMethodInfoPtr__ctor_Public_Void_SECTR_AudioCue_ClipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_ComputeRMS.BakeInfo>.NativeClassPtr, 100664136);
			}

			// Token: 0x06004B7B RID: 19323 RVA: 0x00117254 File Offset: 0x00115454
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 5426, RefRangeEnd = 5459, XrefRangeStart = 5426, XrefRangeEnd = 5459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BakeInfo(SECTR_AudioCue cue, SECTR_AudioCue.ClipData clipData)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_ComputeRMS.BakeInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cue);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clipData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_ComputeRMS.BakeInfo.NativeMethodInfoPtr__ctor_Public_Void_SECTR_AudioCue_ClipData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004B7C RID: 19324 RVA: 0x0002C593 File Offset: 0x0002A793
			public BakeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004B7D RID: 19325 RVA: 0x0002C59C File Offset: 0x0002A79C
			public BakeInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_ComputeRMS.BakeInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17001B7B RID: 7035
			// (get) Token: 0x06004B7E RID: 19326 RVA: 0x001172B8 File Offset: 0x001154B8
			// (set) Token: 0x06004B7F RID: 19327 RVA: 0x0002C5AE File Offset: 0x0002A7AE
			public unsafe SECTR_AudioCue cue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.BakeInfo.NativeFieldInfoPtr_cue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.BakeInfo.NativeFieldInfoPtr_cue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7C RID: 7036
			// (get) Token: 0x06004B80 RID: 19328 RVA: 0x001172E8 File Offset: 0x001154E8
			// (set) Token: 0x06004B81 RID: 19329 RVA: 0x0002C5CD File Offset: 0x0002A7CD
			public unsafe SECTR_AudioCue.ClipData clipData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.BakeInfo.NativeFieldInfoPtr_clipData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue.ClipData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_ComputeRMS.BakeInfo.NativeFieldInfoPtr_clipData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003180 RID: 12672
			private static readonly IntPtr NativeFieldInfoPtr_cue;

			// Token: 0x04003181 RID: 12673
			private static readonly IntPtr NativeFieldInfoPtr_clipData;

			// Token: 0x04003182 RID: 12674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SECTR_AudioCue_ClipData_0;
		}
	}
}
