using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppAudioHelm
{
	// Token: 0x0200028C RID: 652
	public static class Utils : global::Il2CppSystem.Object
	{
		// Token: 0x0600495B RID: 18779 RVA: 0x00111130 File Offset: 0x0010F330
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AudioHelm", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr_kMidiSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kMidiSize");
			Utils.NativeFieldInfoPtr_kNotesPerOctave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kNotesPerOctave");
			Utils.NativeFieldInfoPtr_kMaxChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kMaxChannels");
			Utils.NativeFieldInfoPtr_kBpmToSixteenths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kBpmToSixteenths");
			Utils.NativeFieldInfoPtr_kSecondsPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kSecondsPerMinute");
			Utils.NativeFieldInfoPtr_kSixteenthsPerBeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kSixteenthsPerBeat");
			Utils.NativeFieldInfoPtr_kMinOctave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kMinOctave");
			Utils.NativeFieldInfoPtr_kMiddleC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kMiddleC");
			Utils.NativeFieldInfoPtr_blackKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "blackKeys");
			Utils.NativeMethodInfoPtr_IsBlackKey_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100670829);
			Utils.NativeMethodInfoPtr_IsC_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100670830);
			Utils.NativeMethodInfoPtr_GetOctave_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100670831);
			Utils.NativeMethodInfoPtr_MidiChangeToRatio_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100670832);
			Utils.NativeMethodInfoPtr_RemapRange_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100670833);
			Utils.NativeMethodInfoPtr_RangesOverlap_Public_Static_Boolean_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100670834);
			Utils.NativeMethodInfoPtr_InitAudioSource_Public_Static_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100670835);
			Utils.NativeMethodInfoPtr_CopyComponent_Public_Static_T_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100670836);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x001112B4 File Offset: 0x0010F4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117783, XrefRangeEnd = 117787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBlackKey(int key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsBlackKey_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x001112F4 File Offset: 0x0010F4F4
		[CallerCount(0)]
		public unsafe static bool IsC(int key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsC_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00111334 File Offset: 0x0010F534
		[CallerCount(0)]
		public unsafe static int GetOctave(int key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetOctave_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00111374 File Offset: 0x0010F574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117787, XrefRangeEnd = 117788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float MidiChangeToRatio(int midi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref midi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_MidiChangeToRatio_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x001113B4 File Offset: 0x0010F5B4
		[CallerCount(0)]
		public unsafe static float RemapRange(float oldValue, float oldMin, float oldMax, float newMin, float newMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMin;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_RemapRange_Public_Static_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x0011142C File Offset: 0x0010F62C
		[CallerCount(0)]
		public unsafe static bool RangesOverlap(float start, float end, float rangeStart, float rangeEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_RangesOverlap_Public_Static_Boolean_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00111494 File Offset: 0x0010F694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117808, RefRangeEnd = 117810, XrefRangeStart = 117788, XrefRangeEnd = 117808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitAudioSource(AudioSource audio)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audio);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_InitAudioSource_Public_Static_Void_AudioSource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x001114CC File Offset: 0x0010F6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117827, RefRangeEnd = 117828, XrefRangeStart = 117810, XrefRangeEnd = 117827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CopyComponent<T>(T original, GameObject destination) where T : Component
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref original;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_CopyComponent_Public_Static_T_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x0002B376 File Offset: 0x00029576
		public Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x00111568 File Offset: 0x0010F768
		// (set) Token: 0x06004966 RID: 18790 RVA: 0x0002B37F File Offset: 0x0002957F
		public unsafe static int kMidiSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kMidiSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kMidiSize, (void*)(&value));
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x00111584 File Offset: 0x0010F784
		// (set) Token: 0x06004968 RID: 18792 RVA: 0x0002B38D File Offset: 0x0002958D
		public unsafe static int kNotesPerOctave
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kNotesPerOctave, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kNotesPerOctave, (void*)(&value));
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x001115A0 File Offset: 0x0010F7A0
		// (set) Token: 0x0600496A RID: 18794 RVA: 0x0002B39B File Offset: 0x0002959B
		public unsafe static int kMaxChannels
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kMaxChannels, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kMaxChannels, (void*)(&value));
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x001115BC File Offset: 0x0010F7BC
		// (set) Token: 0x0600496C RID: 18796 RVA: 0x0002B3A9 File Offset: 0x000295A9
		public unsafe static float kBpmToSixteenths
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kBpmToSixteenths, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kBpmToSixteenths, (void*)(&value));
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x001115D8 File Offset: 0x0010F7D8
		// (set) Token: 0x0600496E RID: 18798 RVA: 0x0002B3B7 File Offset: 0x000295B7
		public unsafe static double kSecondsPerMinute
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kSecondsPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kSecondsPerMinute, (void*)(&value));
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x001115F4 File Offset: 0x0010F7F4
		// (set) Token: 0x06004970 RID: 18800 RVA: 0x0002B3C5 File Offset: 0x000295C5
		public unsafe static double kSixteenthsPerBeat
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kSixteenthsPerBeat, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kSixteenthsPerBeat, (void*)(&value));
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06004971 RID: 18801 RVA: 0x00111610 File Offset: 0x0010F810
		// (set) Token: 0x06004972 RID: 18802 RVA: 0x0002B3D3 File Offset: 0x000295D3
		public unsafe static int kMinOctave
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kMinOctave, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kMinOctave, (void*)(&value));
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06004973 RID: 18803 RVA: 0x0011162C File Offset: 0x0010F82C
		// (set) Token: 0x06004974 RID: 18804 RVA: 0x0002B3E1 File Offset: 0x000295E1
		public unsafe static int kMiddleC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kMiddleC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kMiddleC, (void*)(&value));
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06004975 RID: 18805 RVA: 0x00111648 File Offset: 0x0010F848
		// (set) Token: 0x06004976 RID: 18806 RVA: 0x0002B3EF File Offset: 0x000295EF
		public unsafe static Il2CppStructArray<bool> blackKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_blackKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_blackKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F85 RID: 12165
		private static readonly IntPtr NativeFieldInfoPtr_kMidiSize;

		// Token: 0x04002F86 RID: 12166
		private static readonly IntPtr NativeFieldInfoPtr_kNotesPerOctave;

		// Token: 0x04002F87 RID: 12167
		private static readonly IntPtr NativeFieldInfoPtr_kMaxChannels;

		// Token: 0x04002F88 RID: 12168
		private static readonly IntPtr NativeFieldInfoPtr_kBpmToSixteenths;

		// Token: 0x04002F89 RID: 12169
		private static readonly IntPtr NativeFieldInfoPtr_kSecondsPerMinute;

		// Token: 0x04002F8A RID: 12170
		private static readonly IntPtr NativeFieldInfoPtr_kSixteenthsPerBeat;

		// Token: 0x04002F8B RID: 12171
		private static readonly IntPtr NativeFieldInfoPtr_kMinOctave;

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeFieldInfoPtr_kMiddleC;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeFieldInfoPtr_blackKeys;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeMethodInfoPtr_IsBlackKey_Public_Static_Boolean_Int32_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_IsC_Public_Static_Boolean_Int32_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_GetOctave_Public_Static_Int32_Int32_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly IntPtr NativeMethodInfoPtr_MidiChangeToRatio_Public_Static_Single_Int32_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeMethodInfoPtr_RemapRange_Public_Static_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr_RangesOverlap_Public_Static_Boolean_Single_Single_Single_Single_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr_InitAudioSource_Public_Static_Void_AudioSource_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeMethodInfoPtr_CopyComponent_Public_Static_T_T_GameObject_0;

		// Token: 0x020003F4 RID: 1012
		private sealed class MethodInfoStoreGeneric_CopyComponent_Public_Static_T_T_GameObject_0<T>
		{
			// Token: 0x04003CC2 RID: 15554
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_CopyComponent_Public_Static_T_T_GameObject_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
