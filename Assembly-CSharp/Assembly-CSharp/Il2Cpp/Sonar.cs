using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000199 RID: 409
	public class Sonar : MonoBehaviour
	{
		// Token: 0x06002FD7 RID: 12247 RVA: 0x000B8140 File Offset: 0x000B6340
		// Note: this type is marked as 'beforefieldinit'.
		static Sonar()
		{
			Il2CppClassPointerStore<Sonar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Sonar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sonar>.NativeClassPtr);
			Sonar.NativeMethodInfoPtr_Emit_Public_Static_Void_Vector3_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sonar>.NativeClassPtr, 100667030);
			Sonar.NativeMethodInfoPtr_Emit_Public_Static_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sonar>.NativeClassPtr, 100667031);
			Sonar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sonar>.NativeClassPtr, 100667032);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x000B81AC File Offset: 0x000B63AC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 83810, RefRangeEnd = 83829, XrefRangeStart = 83804, XrefRangeEnd = 83810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Emit(Vector3 pos, float rad, Vector2 dest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sonar.NativeMethodInfoPtr_Emit_Public_Static_Void_Vector3_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x000B81FC File Offset: 0x000B63FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83829, XrefRangeEnd = 83830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Emit(Vector3 pos, float rad)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sonar.NativeMethodInfoPtr_Emit_Public_Static_Void_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x000B823C File Offset: 0x000B643C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sonar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sonar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sonar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x00020FBE File Offset: 0x0001F1BE
		public Sonar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Static_Void_Vector3_Single_Vector2_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Static_Void_Vector3_Single_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
