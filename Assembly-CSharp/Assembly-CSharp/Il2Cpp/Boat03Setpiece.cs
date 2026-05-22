using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000085 RID: 133
	public class Boat03Setpiece : MonoBehaviour
	{
		// Token: 0x06001098 RID: 4248 RVA: 0x00064634 File Offset: 0x00062834
		// Note: this type is marked as 'beforefieldinit'.
		static Boat03Setpiece()
		{
			Il2CppClassPointerStore<Boat03Setpiece>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Boat03Setpiece");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Boat03Setpiece>.NativeClassPtr);
			Boat03Setpiece.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece>.NativeClassPtr, 100664688);
			Boat03Setpiece.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece>.NativeClassPtr, 100664689);
			Boat03Setpiece.NativeMethodInfoPtr_Waves_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece>.NativeClassPtr, 100664690);
			Boat03Setpiece.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece>.NativeClassPtr, 100664691);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x000646B4 File Offset: 0x000628B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48365, XrefRangeEnd = 48369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x000646E8 File Offset: 0x000628E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48369, XrefRangeEnd = 48371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0006471C File Offset: 0x0006291C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48371, XrefRangeEnd = 48374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Waves()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece.NativeMethodInfoPtr_Waves_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0006475C File Offset: 0x0006295C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Boat03Setpiece()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Boat03Setpiece>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0000C402 File Offset: 0x0000A602
		public Boat03Setpiece(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_Waves_Private_IEnumerator_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D6 RID: 726
		[ObfuscatedName("Boat03Setpiece+<Waves>d__2")]
		public sealed class _Waves_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D10 RID: 19728 RVA: 0x0011B418 File Offset: 0x00119618
			// Note: this type is marked as 'beforefieldinit'.
			static _Waves_d__2()
			{
				Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Boat03Setpiece>.NativeClassPtr, "<Waves>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr);
				Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, "<>1__state");
				Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, "<>2__current");
				Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, "<timer>5__2");
				Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, 100664692);
				Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, 100664693);
				Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, 100664694);
				Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, 100664695);
				Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, 100664696);
				Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr, 100664697);
			}

			// Token: 0x06004D11 RID: 19729 RVA: 0x0011B4F8 File Offset: 0x001196F8
			[CallerCount(0)]
			public unsafe _Waves_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Boat03Setpiece._Waves_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D12 RID: 19730 RVA: 0x0011B540 File Offset: 0x00119740
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D13 RID: 19731 RVA: 0x0011B574 File Offset: 0x00119774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48264, XrefRangeEnd = 48360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C15 RID: 7189
			// (get) Token: 0x06004D14 RID: 19732 RVA: 0x0011B5B0 File Offset: 0x001197B0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D15 RID: 19733 RVA: 0x0011B5F0 File Offset: 0x001197F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48360, XrefRangeEnd = 48365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C16 RID: 7190
			// (get) Token: 0x06004D16 RID: 19734 RVA: 0x0011B624 File Offset: 0x00119824
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Boat03Setpiece._Waves_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D17 RID: 19735 RVA: 0x0002D576 File Offset: 0x0002B776
			public _Waves_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C12 RID: 7186
			// (get) Token: 0x06004D18 RID: 19736 RVA: 0x0011B664 File Offset: 0x00119864
			// (set) Token: 0x06004D19 RID: 19737 RVA: 0x0002D57F File Offset: 0x0002B77F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C13 RID: 7187
			// (get) Token: 0x06004D1A RID: 19738 RVA: 0x0011B68C File Offset: 0x0011988C
			// (set) Token: 0x06004D1B RID: 19739 RVA: 0x0002D59A File Offset: 0x0002B79A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C14 RID: 7188
			// (get) Token: 0x06004D1C RID: 19740 RVA: 0x0011B6BC File Offset: 0x001198BC
			// (set) Token: 0x06004D1D RID: 19741 RVA: 0x0002D5B9 File Offset: 0x0002B7B9
			public unsafe float _timer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr__timer_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Boat03Setpiece._Waves_d__2.NativeFieldInfoPtr__timer_5__2)) = value;
				}
			}

			// Token: 0x04003276 RID: 12918
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003277 RID: 12919
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003278 RID: 12920
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__2;

			// Token: 0x04003279 RID: 12921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400327A RID: 12922
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400327B RID: 12923
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400327C RID: 12924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400327D RID: 12925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400327E RID: 12926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
