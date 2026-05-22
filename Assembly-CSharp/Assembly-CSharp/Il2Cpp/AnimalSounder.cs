using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001D RID: 29
	public class AnimalSounder : MonoBehaviour
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x0003EFA8 File Offset: 0x0003D1A8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimalSounder()
		{
			Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimalSounder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr);
			AnimalSounder.NativeFieldInfoPtr_MyCue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, "MyCue");
			AnimalSounder.NativeFieldInfoPtr_minTimeBetweenSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, "minTimeBetweenSounds");
			AnimalSounder.NativeFieldInfoPtr_maxTimeBetweenSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, "maxTimeBetweenSounds");
			AnimalSounder.NativeFieldInfoPtr_currentPlayingInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, "currentPlayingInstance");
			AnimalSounder.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, 100663560);
			AnimalSounder.NativeMethodInfoPtr_WaitForABitBeforeSoudingAtStart_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, 100663561);
			AnimalSounder.NativeMethodInfoPtr_WaitThenMakeASound_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, 100663562);
			AnimalSounder.NativeMethodInfoPtr_MakeASoundNow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, 100663563);
			AnimalSounder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, 100663564);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0003F08C File Offset: 0x0003D28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34388, XrefRangeEnd = 34392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0003F0C0 File Offset: 0x0003D2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34392, XrefRangeEnd = 34395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForABitBeforeSoudingAtStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder.NativeMethodInfoPtr_WaitForABitBeforeSoudingAtStart_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0003F100 File Offset: 0x0003D300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34395, XrefRangeEnd = 34398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitThenMakeASound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder.NativeMethodInfoPtr_WaitThenMakeASound_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0003F140 File Offset: 0x0003D340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34398, XrefRangeEnd = 34411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeASoundNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder.NativeMethodInfoPtr_MakeASoundNow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0003F174 File Offset: 0x0003D374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimalSounder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00004A2D File Offset: 0x00002C2D
		public AnimalSounder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0003F1B0 File Offset: 0x0003D3B0
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00004A36 File Offset: 0x00002C36
		public unsafe SECTR_AudioCue MyCue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder.NativeFieldInfoPtr_MyCue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioCue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder.NativeFieldInfoPtr_MyCue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0003F1E0 File Offset: 0x0003D3E0
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00004A55 File Offset: 0x00002C55
		public unsafe float minTimeBetweenSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder.NativeFieldInfoPtr_minTimeBetweenSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder.NativeFieldInfoPtr_minTimeBetweenSounds)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0003F208 File Offset: 0x0003D408
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00004A70 File Offset: 0x00002C70
		public unsafe float maxTimeBetweenSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder.NativeFieldInfoPtr_maxTimeBetweenSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder.NativeFieldInfoPtr_maxTimeBetweenSounds)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0003F230 File Offset: 0x0003D430
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00004A8B File Offset: 0x00002C8B
		public SECTR_AudioCueInstance currentPlayingInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder.NativeFieldInfoPtr_currentPlayingInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder.NativeFieldInfoPtr_currentPlayingInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_MyCue;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_minTimeBetweenSounds;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_maxTimeBetweenSounds;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_currentPlayingInstance;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_WaitForABitBeforeSoudingAtStart_Private_IEnumerator_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_WaitThenMakeASound_Private_IEnumerator_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_MakeASoundNow_Public_Void_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002A6 RID: 678
		[ObfuscatedName("AnimalSounder+<WaitForABitBeforeSoudingAtStart>d__5")]
		public sealed class _WaitForABitBeforeSoudingAtStart_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A85 RID: 19077 RVA: 0x00113F68 File Offset: 0x00112168
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForABitBeforeSoudingAtStart_d__5()
			{
				Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, "<WaitForABitBeforeSoudingAtStart>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr);
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, "<>1__state");
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, "<>2__current");
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, "<>4__this");
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, 100663565);
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, 100663566);
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, 100663567);
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, 100663568);
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, 100663569);
				AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr, 100663570);
			}

			// Token: 0x06004A86 RID: 19078 RVA: 0x00114048 File Offset: 0x00112248
			[CallerCount(0)]
			public unsafe _WaitForABitBeforeSoudingAtStart_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A87 RID: 19079 RVA: 0x00114090 File Offset: 0x00112290
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A88 RID: 19080 RVA: 0x001140C4 File Offset: 0x001122C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34358, XrefRangeEnd = 34361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B1C RID: 6940
			// (get) Token: 0x06004A89 RID: 19081 RVA: 0x00114100 File Offset: 0x00112300
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A8A RID: 19082 RVA: 0x00114140 File Offset: 0x00112340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34361, XrefRangeEnd = 34366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B1D RID: 6941
			// (get) Token: 0x06004A8B RID: 19083 RVA: 0x00114174 File Offset: 0x00112374
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A8C RID: 19084 RVA: 0x0002BE70 File Offset: 0x0002A070
			public _WaitForABitBeforeSoudingAtStart_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B19 RID: 6937
			// (get) Token: 0x06004A8D RID: 19085 RVA: 0x001141B4 File Offset: 0x001123B4
			// (set) Token: 0x06004A8E RID: 19086 RVA: 0x0002BE79 File Offset: 0x0002A079
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B1A RID: 6938
			// (get) Token: 0x06004A8F RID: 19087 RVA: 0x001141DC File Offset: 0x001123DC
			// (set) Token: 0x06004A90 RID: 19088 RVA: 0x0002BE94 File Offset: 0x0002A094
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1B RID: 6939
			// (get) Token: 0x06004A91 RID: 19089 RVA: 0x0011420C File Offset: 0x0011240C
			// (set) Token: 0x06004A92 RID: 19090 RVA: 0x0002BEB3 File Offset: 0x0002A0B3
			public unsafe AnimalSounder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimalSounder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitForABitBeforeSoudingAtStart_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040030A5 RID: 12453
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040030A6 RID: 12454
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040030A7 RID: 12455
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040030A8 RID: 12456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040030A9 RID: 12457
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040030AA RID: 12458
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040030AB RID: 12459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040030AC RID: 12460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040030AD RID: 12461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002A7 RID: 679
		[ObfuscatedName("AnimalSounder+<WaitThenMakeASound>d__6")]
		public sealed class _WaitThenMakeASound_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A93 RID: 19091 RVA: 0x0011423C File Offset: 0x0011243C
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitThenMakeASound_d__6()
			{
				Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimalSounder>.NativeClassPtr, "<WaitThenMakeASound>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr);
				AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, "<>1__state");
				AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, "<>2__current");
				AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, "<>4__this");
				AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, 100663571);
				AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, 100663572);
				AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, 100663573);
				AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, 100663574);
				AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, 100663575);
				AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr, 100663576);
			}

			// Token: 0x06004A94 RID: 19092 RVA: 0x0011431C File Offset: 0x0011251C
			[CallerCount(0)]
			public unsafe _WaitThenMakeASound_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimalSounder._WaitThenMakeASound_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A95 RID: 19093 RVA: 0x00114364 File Offset: 0x00112564
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A96 RID: 19094 RVA: 0x00114398 File Offset: 0x00112598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34366, XrefRangeEnd = 34383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B21 RID: 6945
			// (get) Token: 0x06004A97 RID: 19095 RVA: 0x001143D4 File Offset: 0x001125D4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A98 RID: 19096 RVA: 0x00114414 File Offset: 0x00112614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34383, XrefRangeEnd = 34388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B22 RID: 6946
			// (get) Token: 0x06004A99 RID: 19097 RVA: 0x00114448 File Offset: 0x00112648
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimalSounder._WaitThenMakeASound_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A9A RID: 19098 RVA: 0x0002BED2 File Offset: 0x0002A0D2
			public _WaitThenMakeASound_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B1E RID: 6942
			// (get) Token: 0x06004A9B RID: 19099 RVA: 0x00114488 File Offset: 0x00112688
			// (set) Token: 0x06004A9C RID: 19100 RVA: 0x0002BEDB File Offset: 0x0002A0DB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B1F RID: 6943
			// (get) Token: 0x06004A9D RID: 19101 RVA: 0x001144B0 File Offset: 0x001126B0
			// (set) Token: 0x06004A9E RID: 19102 RVA: 0x0002BEF6 File Offset: 0x0002A0F6
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B20 RID: 6944
			// (get) Token: 0x06004A9F RID: 19103 RVA: 0x001144E0 File Offset: 0x001126E0
			// (set) Token: 0x06004AA0 RID: 19104 RVA: 0x0002BF15 File Offset: 0x0002A115
			public unsafe AnimalSounder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimalSounder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimalSounder._WaitThenMakeASound_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040030AE RID: 12462
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040030AF RID: 12463
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040030B0 RID: 12464
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040030B1 RID: 12465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040030B2 RID: 12466
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040030B3 RID: 12467
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040030B4 RID: 12468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040030B5 RID: 12469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040030B6 RID: 12470
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
