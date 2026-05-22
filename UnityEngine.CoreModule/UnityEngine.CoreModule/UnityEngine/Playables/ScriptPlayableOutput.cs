using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000191 RID: 401
	[StructLayout(2)]
	public struct ScriptPlayableOutput
	{
		// Token: 0x06001EBE RID: 7870 RVA: 0x00071058 File Offset: 0x0006F258
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPlayableOutput()
		{
			Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr);
			ScriptPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, "m_Handle");
			ScriptPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100666110);
			ScriptPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100666111);
			ScriptPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100666112);
			ScriptPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100666113);
			ScriptPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100666114);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00071100 File Offset: 0x0006F300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504412, RefRangeEnd = 504413, XrefRangeStart = 504392, XrefRangeEnd = 504412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayableOutput Create(PlayableGraph graph, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00071150 File Offset: 0x0006F350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504413, XrefRangeEnd = 504417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptPlayableOutput(PlayableOutputHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x00071184 File Offset: 0x0006F384
		public unsafe static ScriptPlayableOutput Null
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 504442, RefRangeEnd = 504443, XrefRangeStart = 504417, XrefRangeEnd = 504442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x000711B4 File Offset: 0x0006F3B4
		[CallerCount(0)]
		public unsafe PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x000711E4 File Offset: 0x0006F3E4
		[CallerCount(0)]
		public unsafe static implicit operator PlayableOutput(ScriptPlayableOutput output)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref output;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0001008A File Offset: 0x0000E28A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00071224 File Offset: 0x0006F424
		public static explicit operator ScriptPlayableOutput(PlayableOutput output)
		{
			return new ScriptPlayableOutput(output.GetHandle());
		}

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0;

		// Token: 0x04001793 RID: 6035
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;
	}
}
